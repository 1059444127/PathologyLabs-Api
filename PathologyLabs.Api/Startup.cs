using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PathologyLabs.Domain.App;
using PathologyLabs.Repositories;
using PathologyLabs.Services;

namespace PathologyLabs.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services
                .AddScoped(typeof(IRepository<,>), typeof(Repository<,>))
                .AddScoped(typeof(IService<,,>), typeof(Service<,,>))
                .AddDbContext<PathologyLabsDbContext>(options =>
                    options.UseSqlServer(this.Configuration.GetConnectionString("Default")))
                .AddIdentity<PathologyLabsUser, IdentityRole<long>>(option => option.Lockout.MaxFailedAccessAttempts = 5)
                .AddEntityFrameworkStores<PathologyLabsDbContext>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}

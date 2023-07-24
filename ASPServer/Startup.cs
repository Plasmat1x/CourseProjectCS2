using ASPServer.Domain.Repositories;
using ASPServer.Domain.Repositories.Abstract;
using ASPServer.Domain.Repositories.EnitityFramework;
using ASPServer.Service;
using Microsoft.EntityFrameworkCore;

namespace ASPServer
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration) => Configuration = configuration;
        public void ConfigureServices(IServiceCollection services)
        {
            Configuration.Bind("Project", new Config());

            services.AddTransient<IUserRepository, EFUserRepository>();
            services.AddTransient<IMessageRepository, EFMessageRepository>();
            //services.AddTransient<DataManager>();

            services.AddDbContext<AppDbContext>(x => x.UseSqlServer(Config.ConnectionString));

            services.AddControllers();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}

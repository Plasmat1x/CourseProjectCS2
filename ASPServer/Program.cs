using ASPServer.Domain;
using ASPServer.Models;
using ASPServer.Models.Repository.Abstract;
using ASPServer.Models.Repository.EF;
using Microsoft.EntityFrameworkCore;

namespace ASPServer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var conntectioString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("DefaultConnection string not found");

            builder.Services.AddTransient<IMessageRepo, MessageEF>();
            builder.Services.AddTransient<IChatRepo, ChatEF>();
            builder.Services.AddTransient<IUserRepo, UserEF>();
            builder.Services.AddTransient<DataManager>();
            builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(conntectioString));
            builder.Services.AddControllers();

            var app = builder.Build();

            app.UseRouting();

            app.UseEndpoints(ep =>
            {
                ep.MapControllerRoute("default", "{controller}/{action?}");
            });

            app.Run();
        }
    }
}
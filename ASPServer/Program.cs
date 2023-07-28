using ASPServer.Domain;
using Microsoft.EntityFrameworkCore;

namespace ASPServer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var conntectioString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("DefaultConnection string not found");
            builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(conntectioString));


            var app = builder.Build();

            app.UseRouting();

            app.Run();
        }
    }
}
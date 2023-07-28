using ASPServer.Domain;
using ASPServer.Models.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ASPServer.Controllers
{
    public class UserController : Controller
    {
        private readonly AppDbContext context;

        public UserController(AppDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<User>> GetUser(string uname)
        {
            return await context.Users.FirstOrDefaultAsync(x => x.Username == uname);
        }

        [HttpPost]
        public async Task<ActionResult<User>> AddUser(string uname)
        {
            User u = new User { Username = uname };
            context.Add(u);
            await context.SaveChangesAsync();
            return await context.Users.FirstOrDefaultAsync(x => x.Username == uname);
        }
    }
}

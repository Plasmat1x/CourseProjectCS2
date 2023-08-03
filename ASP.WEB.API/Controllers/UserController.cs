using ASP.WEB.API.Context;
using ASP.WEB.API.Context.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ASP.WEB.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        AppDbContext context;
        public UserController(AppDbContext context)
        {
            this.context = context;
        }

        [HttpGet("User")]
        public async Task<IActionResult> GetUser(string Name, CancellationToken ct)
        {
            User user = await context.Users.FirstOrDefaultAsync(x => x.Name == Name, ct);

            if (user == null)
            {
                return NotFound($"User with {Name} not founded");
            }

            return Ok(user);
        }

        [HttpGet("Users")]
        public async Task<IActionResult> GetUsers(CancellationToken ct)
        {
            var List = await context.Users.ToArrayAsync(ct);
            return Ok(List);
        }

        [HttpGet("UserChats")]
        public async Task<IActionResult> GetUserChats(string Name, CancellationToken ct)
        {
            var u = await (from uc in context.UserChats
                           join chat in context.Chats on uc.ChatId equals chat.Id
                           join user in context.Users on uc.UserId equals user.Id
                           where user.Name == Name
                           select uc)
                           .ToArrayAsync(ct);

            return Ok(u);
        }

        [HttpGet("ChatOwner")]
        public async Task<IActionResult> GetChatOwner(string Name, CancellationToken ct)
        {
            var res = await (from uc in context.UserChats
                             join chat in context.Chats on uc.ChatId equals chat.Id
                             join user in context.Users on uc.UserId equals user.Id
                             where chat.Name == Name
                             select chat.Owner)
                             .FirstOrDefaultAsync(ct);

            return Ok(res);
        }

        [HttpGet("GetContacts")]
        public async Task<IActionResult> GetContacts(string Name, CancellationToken ct)
        {
            var res = await (from con in context.Contacts
                             join owner in context.Users on con.OwnerId equals owner.Id
                             join user in context.Users on con.UserId equals user.Id
                             where owner.Name == Name
                             orderby con.User.Name
                             select con).ToArrayAsync(ct);

            return Ok(res);
        }
    }
}

using ASP.WEB.API.Context;
using ASP.WEB.API.Context.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ASP.WEB.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChatController : ControllerBase
    {
        AppDbContext context;
        public ChatController(AppDbContext context)
        {
            this.context = context;
        }

        [HttpPost("AddUserToChat")]
        public async Task<IActionResult> AddUserToChat(int userid, int chatid, CancellationToken ct)
        {

            await context.UserChats.AddAsync(new UserChat { UserId = userid, ChatId = chatid, AddedTime = DateTime.Now }, ct);

            await context.SaveChangesAsync(ct);

            return Ok("User Added");
        }

        [HttpPost("SendMessageToChat")]
        public async Task<IActionResult> SendMessage(int chatid, string message, int sender, CancellationToken ct)
        {
            await context.Messages.AddAsync(new Message { ChatId = chatid, SenderId = sender, Text = message, CreatedAt = DateTime.Now }, ct);
            await context.SaveChangesAsync(ct);
            return Ok();
        }
    }
}

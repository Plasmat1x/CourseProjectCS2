using ASPServer.Domain;
using ASPServer.Models.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ASPServer.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MessageController : Controller
    {
        private readonly AppDbContext context;

        public MessageController(AppDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Message>>> GetMessagesFromChat(int chat_id)
        {
            return await context.Messages.ToListAsync();
        }

        public async Task<IActionResult> SendMessage(Message message)
        {
            context.Messages.Add(message);
            await context.SaveChangesAsync();
            return Ok();
        }
    }
}

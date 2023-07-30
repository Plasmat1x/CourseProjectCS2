using ASPServer.Models;
using ASPServer.Models.Entity;
using Microsoft.AspNetCore.Mvc;

namespace ASPServer.Controllers
{
    public class MessageController : Controller
    {
        private DataManager dm;

        public MessageController(DataManager dm)
        {
            this.dm = dm;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Message>> GetMessagesFromChat(int chat_id)
        {
            return dm.MessageRepo.GetMessages(chat_id).ToList();
        }

        [HttpPost]
        public async Task<IActionResult> SendMessage(Message message)
        {
            dm.MessageRepo.AddMessage(message);
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> SendMessage(string from, string to, string text)
        {
            Message msg = new Message
            {
                From_user = dm.UserRepo.GetUser(from),
                To_user = dm.UserRepo.GetUser(to),
                Content = text,
                Created_at = DateTime.UtcNow,
            };
            dm.MessageRepo.AddMessage(msg);
            return Ok();
        }
    }
}

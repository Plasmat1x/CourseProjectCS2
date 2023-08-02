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
            return NotFound(null);
        }

        [HttpPost]
        public async Task<IActionResult> SendMessage(Message message)
        {
            return NotFound(null);
        }

        [HttpPost]
        public async Task<IActionResult> SendMessage(string from, string to, string text)
        {
            return NotFound(null);
        }
    }
}

using ASPServer.Models;
using ASPServer.Models.Entity;
using Microsoft.AspNetCore.Mvc;

namespace ASPServer.Controllers
{
    public class ChatController : Controller
    {
        private DataManager dm;

        public ChatController(DataManager dm)
        {
            this.dm = dm;
        }

        [HttpGet]
        public ActionResult<Chat> GetChat(int id)
        {
            return null;
        }

        [HttpPost]
        public IActionResult DeleteChat(int id)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult CreateChat(User requester)
        {
            return Ok();
        }

    }
}

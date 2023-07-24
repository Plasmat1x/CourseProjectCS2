using Microsoft.AspNetCore.Mvc;

namespace ASPServer.Controllers
{
    public class ChatController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

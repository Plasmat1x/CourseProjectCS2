using ASPServer.Models;
using ASPServer.Models.Entity;
using Microsoft.AspNetCore.Mvc;

namespace ASPServer.Controllers
{
    public class UserController : Controller
    {
        private DataManager dm;

        public UserController(DataManager dm)
        {
            this.dm = dm;
        }

        [HttpGet]
        public ActionResult<User> GetUser(string uname)
        {
            return dm.UserRepo.GetUser(uname);
        }

        [HttpPost]
        public IActionResult AddUser(string uname)
        {

            User u = dm.UserRepo.GetUser(uname);

            if (u != null)
            {
                return Conflict();
            }

            dm.UserRepo.AddUser(uname);
            return Ok();
        }

        [HttpPost]
        public IActionResult DeleteUser(int id)
        {
            dm.UserRepo.DeleteUser(id);
            return Ok();
        }
    }
}

﻿using ASPServer.Models;
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
            return dm.ChatRepo.GetChat(id);
        }

        [HttpPost]
        public IActionResult DeleteChat(int id)
        {
            dm.ChatRepo.RemoveChat(id);
            return Ok();
        }

        [HttpPost]
        public IActionResult CreateChat(User owner, User target)
        {
            dm.ChatRepo.AddChat(new Chat
            {
                CreatedAt = DateTime.UtcNow,
                Users = new List<User> { owner, target },
            });
            return Ok();
        }

    }
}
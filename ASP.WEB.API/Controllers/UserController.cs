﻿using ASP.WEB.API.Context;
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
            var res = await context.Users.FirstOrDefaultAsync(x => x.Name == Name, ct);

            if (res == null)
            {
                return NotFound($"User with {Name} not founded");
            }

            return Ok(res);
        }

        [HttpGet("Users")]
        public async Task<IActionResult> GetUsers(CancellationToken ct)
        {
            var List = await context.Users.ToArrayAsync(ct);
            return Ok(List);
        }

        [HttpGet("Chats")]
        public async Task<IActionResult> GetUserChats(int userid, CancellationToken ct)
        {
            var u = await (from uc in context.UserChats
                           join chat in context.Chats on uc.ChatId equals chat.Id
                           join user in context.Users on uc.UserId equals user.Id
                           where user.Id == userid
                           select chat)
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

        [HttpGet("Contacts")]
        public async Task<IActionResult> GetContacts(int userid, CancellationToken ct)
        {
            var res = await (from con in context.Contacts
                             join owner in context.Users on con.OwnerId equals owner.Id
                             join user in context.Users on con.UserId equals user.Id
                             where owner.Id == userid
                             orderby con.User.Name
                             select con).Include(x => x.User).ToArrayAsync(ct);

            return Ok(res);
        }

        [HttpGet("Messages")]
        public async Task<IActionResult> GetMsgFromChat(int chatid, CancellationToken ct)
        {
            var res = await (from msg in context.Messages
                             join chat in context.Chats on msg.ChatId equals chat.Id
                             where chat.Id == chatid
                             orderby msg.CreatedAt ascending
                             select msg)
                             .Include(x => x.Sender)
                             .ToArrayAsync(ct);

            return Ok(res);
        }

        [HttpPost("Create")]
        public async Task<IActionResult> CreateUser(string Username, CancellationToken ct)
        {
            if (await context.Users.FirstOrDefaultAsync(x => x.Name == Username, ct) != null)
            {
                return NotFound($"{Username} already exist");
            }

            await context.Users.AddAsync(new User { Name = Username, CreatedAt = DateTime.Now }, ct);
            await context.SaveChangesAsync(ct);

            return Ok();
        }
    }
}

using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TravelLine.Kitchen.WebApi.Models.Entity;
using TravelLine.Kitchen.WebApi.Models.Dto;
using TravelLine.Kitchen.WebApi.Core;

namespace TravelLine.Kitchen.WebApi.Controllers
{
    [Route("api")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly UserContext dbUser;

        public UsersController(UserContext context)
        {
            dbUser = context;
        }

        [Route("users")]
        public IActionResult AllUsers()
        {
            List<User> users = dbUser.Users.ToList();

            return Ok(users.ConvertAll(
            new Converter<User, UserDto>(Converter.ConvertUsers)));
        }

        [Route("users/{id:int}")]
        public IActionResult Users(int? id = 0)
        {
            var UserId = dbUser.Users.Find(id);

            if (UserId == null)
                return NotFound();
            else
                return Ok(Converter.ConvertUsers(UserId));
        }
    }
}

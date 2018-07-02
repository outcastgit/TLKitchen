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
    public class MenusController : ControllerBase
    {
        private readonly MenuContext dbMenu;

        public MenusController(MenuContext context)
        {
            dbMenu = context;
        }

        [Route("menu")]
        public IActionResult AllMenu()
        {
            List<Menu> menus = dbMenu.Menus.ToList();

            return Ok(menus.ConvertAll(
            new Converter<Menu, MenuDto>(Converter.ConvertMenu)));
        }

        [Route("menu/{id:int}")]
        public IActionResult MenuItem(int? id = 0)
        {
            var MenuId = dbMenu.Menus.Find(id);

            if (MenuId == null)
                return NotFound();
            else
                return Ok(Converter.ConvertMenu(MenuId));
        }
    }
}

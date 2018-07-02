using TravelLine.Kitchen.WebApi.Models.Entity;
using TravelLine.Kitchen.WebApi.Models.Dto;

namespace TravelLine.Kitchen.WebApi.Core
{
    public class Converter
    {
        public static UserDto ConvertUsers(User user)
        {
            return new UserDto
            {
                Id = user.Id,
                Name = user.Name + " " + user.Sername
            };
        }

        public static OrderDto ConvertOrders(Order order)
        {
            return new OrderDto
            {
                Id = order.Id,
                UserId = order.UserId,
                DishId = order.DishId,
                Date = order.Date.ToUniversalTime()
            };
        }

        public static MenuDto ConvertMenu(Menu menu)
        {
            return new MenuDto
            {
                Id = menu.Id,
                Dish = menu.Dish
            };
        }
    }
}

using System;

namespace TravelLine.Kitchen.WebApi.Models.Entity
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int DishId { get; set; }
        public DateTime Date { get; set; }
    }
}
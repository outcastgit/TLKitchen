using Microsoft.EntityFrameworkCore;
using TravelLine.Kitchen.WebApi.Models.Entity;

namespace TravelLine.Kitchen.WebApi
{
    public class OrderContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public OrderContext(DbContextOptions<OrderContext> options)
        : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
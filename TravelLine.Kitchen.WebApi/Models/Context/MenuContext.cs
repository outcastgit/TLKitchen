using Microsoft.EntityFrameworkCore;
using TravelLine.Kitchen.WebApi.Models.Entity;

namespace TravelLine.Kitchen.WebApi
{
    public class MenuContext : DbContext
    {
        public DbSet<Menu> Menus { get; set; }
        public MenuContext(DbContextOptions<MenuContext> options)
        : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
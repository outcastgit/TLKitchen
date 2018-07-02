using Microsoft.EntityFrameworkCore;
using TravelLine.Kitchen.WebApi.Models.Entity;

namespace TravelLine.Kitchen.WebApi
{
    public class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public UserContext(DbContextOptions<UserContext> options)
        : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
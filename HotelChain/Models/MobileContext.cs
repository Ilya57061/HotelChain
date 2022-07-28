using HotelChain.Models.DatabaseModels;
using Microsoft.EntityFrameworkCore;

namespace HotelChain.Models
{

    public class MobileContext : DbContext
    {
        public DbSet<Hotel>? Hotels { get; set; }
        public DbSet<Room>? Rooms { get; set; }

        public MobileContext(DbContextOptions<MobileContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}

using Microsoft.EntityFrameworkCore;

namespace Hotellerie_X.Models.HotellerieModel
{
    public class HotellerieDbContext : DbContext
    {
        public HotellerieDbContext(DbContextOptions<HotellerieDbContext> options)
            : base(options)
        {
        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Appreciation> Appreciations { get; set; }

    }
}
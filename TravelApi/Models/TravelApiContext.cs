using Microsoft.EntityFrameworkCore;

namespace TravelApi.Models
{
    public class TravelApiContext : DbContext
    {
        public TravelApiContext(DbContextOptions<TravelApiContext> options)
            : base(options)
        {
        }
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
          builder.Entity<Travel>()
              .HasData(
                  new Travel { TravelId = 1, Location = "San Fancisco, CA", Country = "United States of America", Blerb = "It was pretty cool, sunny but a nice cool sea breeze. food was great", Rating = 8 },
                  new Travel { TravelId = 2, Location = "Gonzales, CA", Country = "United States of America", Blerb = "This town is whack AF. This is also my home town", Rating = 2 },
                  new Travel { TravelId = 3, Location = "Seattle, WA", Country = "United States of America", Blerb = "I feel like I'm in California, with all the driving i have to do to get around. coffee was over rated but the food was pretty ok", Rating = 4 },
                  new Travel { TravelId = 4, Location = "Monterey, CA", Country = "United States of America", Blerb = "Christopher Moore said it best, the Monterey Peninsula is best for the Newly Wed and Nearly Dead", Rating = 6 },
                  new Travel { TravelId = 5, Location = "Bakersfield, CA", Country = "United States of America", Blerb = "if an armpit was a city, it would be Bakersfield. nothing of note", Rating = 1 },
                  new Travel { TravelId = 6, Location = "Mexico City", Country = "Mexico", Blerb = "this was dope af. a lot of great culture and history. amazing food", Rating = 10 }
              );
        
        }
        public DbSet<Travel> Travels { get; set; }
    }
}
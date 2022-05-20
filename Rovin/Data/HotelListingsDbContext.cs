
using Microsoft.EntityFrameworkCore;

namespace rovin.Data
{
    public class HotelListingsDbContext :DbContext
    {
        public HotelListingsDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Country { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "India",
                    Shortname = "IN"
                },
                new Country
                {
                    Id = 2,
                    Name = "Jamaica",
                    Shortname = "JM"
                },

                  new Country
                  {
                      Id = 3,
                      Name = "USA",
                      Shortname = "US"
                  }

                );

            modelBuilder.Entity<Hotel>().HasData(
               new Hotel
               {
                   Id = 1,
                   Name = "Park",
                   Address = "No 8 India",
                   Rating = 3.5,
                   CountryId = 3
               },
               new Hotel
               {
                   Id = 2,
                   Name = "Taj",
                   Address = "No 32 India",
                   Rating = 4.1,
                   CountryId =2
               },

               new Hotel
               {
                   Id = 3,
                   Name = "Saravana",
                   Address = "No 33 India",
                   Rating = 4.7,
                   CountryId =1
               }

               );
        }
    }
}

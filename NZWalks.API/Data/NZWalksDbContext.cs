using Microsoft.EntityFrameworkCore;
using NZWalks.API.Models;

namespace NZWalks.API.Data
{
    public class NZWalksDbContext : DbContext
    {
        public NZWalksDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<Difficulty> Difficulties { get; set; }

        public DbSet<Region> Regions { get; set; }

        public DbSet<Walk> Walks { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var difficulties = new List<Difficulty>()
            {
                new Difficulty()
                {
                    Id = Guid.Parse("5642667c-737c-4d2a-9993-66fff75f9212"),
                    Name = "Easy"
                },
                new Difficulty()
                {
                    Id = Guid.Parse("48e98710-9b62-4b8d-a990-a770b9d372ca"),
                    Name = "Medium"
                },
                new Difficulty()
                {
                    Id = Guid.Parse("7b3de3f4-9740-43dd-ad3f-d3d092822296"),
                    Name = "Hard"
                }
            };
            modelBuilder.Entity<Difficulty>().HasData(difficulties);

            var regions = new List<Region>
            {
               new Region
                {
                    Id = Guid.Parse("3442236d-cb43-4e94-8a8b-e22c41981ef3"),
                    Name = "Auckland",
                    Code = "AKL",
                    RegionImageUrl = "https://images.pexels.com/photos/5169056/pexels-photo-5169056.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
                },
                new Region
                {
                    Id = Guid.Parse("fb837e87-dff9-42f3-ac44-8f420ee39289"),
                    Name = "Northland",
                    Code = "NTL",
                    RegionImageUrl = null
                },
                new Region
                {
                    Id = Guid.Parse("836a946a-fb51-4283-9ac1-40c7d58fad86"),
                    Name = "Bay Of Plenty",
                    Code = "BOP",
                    RegionImageUrl = null
                },
                new Region
                {
                    Id = Guid.Parse("3f42f64f-8cdf-4425-8e5e-bab6a5af99e2"),
                    Name = "Wellington",
                    Code = "WGN",
                    RegionImageUrl = "https://images.pexels.com/photos/4350631/pexels-photo-4350631.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
                },
                new Region
                {
                    Id = Guid.Parse("fad3b984-9c82-48f4-a409-5a0e582e0332"),
                    Name = "Nelson",
                    Code = "NSN",
                    RegionImageUrl = "https://images.pexels.com/photos/13918194/pexels-photo-13918194.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
                },
                new Region
                {
                    Id = Guid.Parse("eba7c346-28c5-4a33-ac34-06414163e993"),
                    Name = "Southland",
                    Code = "STL",
                    RegionImageUrl = null
                },
            };

            modelBuilder.Entity<Region>().HasData(regions);
        }
    }
}

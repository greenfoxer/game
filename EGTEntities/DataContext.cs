using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EGTEntities
{
    public class DataContext : DbContext
    {
        public DataContext()
            : base("DbConnection")
        { }
        public DbSet<Player> Players { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<LocationPurpose> LocationPurposes { get; set; }
        public DbSet<Area> Areas { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<ResourceType> ResourceTypes { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using egt.Classes.Entities;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace egt.Classes.Contexts
{
    internal class GameContextInitializer : DropCreateDatabaseIfModelChanges<GameContext>
    {
        protected override void Seed(GameContext db)
        {

        }
    } 
    internal class GameContext: DbContext
    {
        static GameContext()
        {
            Database.SetInitializer<GameContext>(new GameContextInitializer());
        }
        public GameContext()
            : base("GameConnectionString")
        {         }

        public virtual void Save()
        {
            base.SaveChanges();
        }
        public override int SaveChanges()
        {
            TrackChanges();
            try
            {
                return base.SaveChanges();
            }

            catch (DbUpdateException dbu)
            {
                var exception = HandleDbUpdateException(dbu);
                throw exception;
            }
        }
        private Exception HandleDbUpdateException(DbUpdateException dbu)
        {
            var builder = new StringBuilder("A DbUpdateException was caught while saving changes. ");

            try
            {
                foreach (var result in dbu.Entries)
                {
                    builder.AppendFormat("Type: {0} was part of the problem. ", result.Entity.GetType().Name);
                }
            }
            catch (Exception e)
            {
                builder.Append("Error parsing DbUpdateException: " + e.ToString());
            }

            string message = builder.ToString();
            return new Exception(message, dbu);
        }
        public DateTime Timestamp { get {return DateTime.UtcNow;} }
        private void TrackChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(e => e.State == EntityState.Added || e.State == EntityState.Modified))
            {
                if (entry.Entity is IObservableElement)
                {
                    var auditable = entry.Entity as IObservableElement;
                    if (entry.State == EntityState.Added)
                    {
                        auditable.CreatedOn = Timestamp;
                        auditable.UpdatedOn = Timestamp;
                    }
                    else
                    {
                        auditable.UpdatedOn = Timestamp;
                    }
                }
            }
        }

        public DbSet<Player> Players { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<LocationPurpose> LocationPurposes { get; set; }
        public DbSet<Area> Areas { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<ResourceType> ResourceTypes { get; set; }
        public DbSet<RuntimeUserAction> RuntimeUserActions { get; set; }
        public DbSet<RuntimeAction> RuntimeActions { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<Buff> Buffs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<Player>().HasMany(c => c.Buffs).WithMany(i => i.Players).Map(t => t.ToTable("tPlayersBufs"));
            modelBuilder.Entity<Player>().HasMany(c => c.Equipments).WithMany(i => i.Players).Map(t => t.ToTable("tPlayersEquipments"));
            modelBuilder.Entity<Resource>().HasMany(c => c.Locations).WithMany(i => i.Resources).Map(t => t.ToTable("tResourcesLocations"));
            modelBuilder.Entity<Equipment>().HasMany(c => c.Buffs).WithMany(i => i.Equipments).Map(t => t.ToTable("tEquipmentsBufs"));
        }
    }
}

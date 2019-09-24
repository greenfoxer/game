using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using egt.Classes.Entities;
using System.Data.Entity;

namespace egt.Classes.Repositories
{
    internal class PlayerConcreteRepository: BaseGenericRepository<Player> 
    {
        public PlayerConcreteRepository(DbContext db)
            : base(db)
        { }
    }
    internal class GroupConcreteRepository: BaseGenericRepository<Group> 
    {
        public GroupConcreteRepository(DbContext db)
            : base(db)
        { }
    }
    internal class ClassConcreteRepository : BaseGenericRepository<Class>
    {
        public ClassConcreteRepository(DbContext db)
            : base(db)
        { }
    }
    internal class LocationConcreteRepository: BaseGenericRepository<Location> 
    {
        public LocationConcreteRepository(DbContext db)
                : base(db)
            { }
    }
    internal class LocationPurposeConcreteRepository: BaseGenericRepository<LocationPurpose> 
    {
        public LocationPurposeConcreteRepository(DbContext db)
            : base(db)
        { }
    }
    internal class AreaConcreteRepository: BaseGenericRepository<Area> 
    {
        public AreaConcreteRepository(DbContext db)
            : base(db)
        { }
    }
    internal class ResourceConcreteRepository: BaseGenericRepository<Resource>
    {
        public ResourceConcreteRepository(DbContext db)
            : base(db)
        { }
    }
    internal class ResourceTypeConcreteRepository: BaseGenericRepository<ResourceType> 
    {
        public ResourceTypeConcreteRepository(DbContext db)
            : base(db)
        { }
    }
    internal class RuntimeUserActionConcreteRepository: BaseGenericRepository<RuntimeUserAction>
    {
        public RuntimeUserActionConcreteRepository(DbContext db)
            : base(db)
        { }
    }
    internal class RuntimeActionConcreteRepository: BaseGenericRepository<RuntimeAction> 
    {
        public RuntimeActionConcreteRepository(DbContext db)
            : base(db)
        { }
    }
    internal class EquipmentConcreteRepository: BaseGenericRepository<Equipment>
    {
        public EquipmentConcreteRepository(DbContext db)
            : base(db)
        { }
    }
    internal class BuffConcreteRepository: BaseGenericRepository<Buff> 
    {
        public BuffConcreteRepository(DbContext db)
            : base(db)
        { }
    }
}

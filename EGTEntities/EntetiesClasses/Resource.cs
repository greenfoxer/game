using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EGTEntities;

namespace EGTEntities
{
    public class Resource
    {
        int id, chance;

        public int Chance
        {
            get { return chance; }
            set { chance = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        string name, description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        ResourceType resourceType;

        internal ResourceType ResourceType
        {
            get { return resourceType; }
            set { resourceType = value; }
        }

        public ICollection<Location> Locations { get; set; }
        bool isRare;

        public bool IsRare
        {
            get { return isRare; }
            set { isRare = value; }
        }
        public Resource()
        {
            Locations = new List<Location>();
        }
    }
}

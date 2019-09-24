using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using egt.Classes.Entities;

namespace egt.Logic.DataTransferObjects
{
    public class ResourceInfo
    {
        public int Chance { get; set; }
        public int Id { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        internal ResourceType ResourceType { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public ICollection<LocationInfo> Locations { get; set; }
        public bool IsRare { get; set; }
        public ResourceInfo()
        {
            Locations = new List<LocationInfo>();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using egt.Classes.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace egt.Classes.Entities
{
    [Table("tResources")]
    internal class Resource:IBaseEntity,IObservableElement
    {
        public int Chance { get; set; }
        public int Id { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        internal ResourceType ResourceType { get; set; }
        //public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
       // public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public ICollection<Location> Locations { get; set; }
        public bool IsRare { get; set; }
        public Resource()
        {
            Locations = new List<Location>();
        }
    }
}

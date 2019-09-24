using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace egt.Classes.Entities
{
    [Table("tLocations")]
    internal class Location:IBaseEntity,IObservableElement
    {
        public int Requirement_stamina { get; set; }
        public int Duration_base { get; set; }
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public bool IsConstant { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public LocationPurpose Purpose { get; set; }
       // public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        //public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public ICollection<Resource> Resources { get; set; }
        public Location()
        {
            Resources = new List<Resource>();
        }
    }
}

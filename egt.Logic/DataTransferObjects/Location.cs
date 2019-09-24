using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace egt.Logic.DataTransferObjects
{
    public class LocationInfo
    {
        public int Requirement_stamina { get; set; }
        public int Duration_base { get; set; }
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public bool IsConstant { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public LocationPurposeInfo Purpose { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public ICollection<ResourceInfo> Resources { get; set; }
        public LocationInfo()
        {
            Resources = new List<ResourceInfo>();
        }
    }
}

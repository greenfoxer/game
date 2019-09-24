using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace egt.Logic.DataTransferObjects
{
    public class ResourceTypeInfo
    {
        public int Name { get; set; }
        public int Id { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}

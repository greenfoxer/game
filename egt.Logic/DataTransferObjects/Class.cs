using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace egt.Logic.DataTransferObjects
{
    public class ClassInfo
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}

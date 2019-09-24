using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace  egt.Classes.Entities
{
    [Table("tRuntimeActions")]
    internal class RuntimeAction: IObservableElement, IBaseEntity
    {
        public int Priority { get; set; }
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace egt.Classes.Entities
{
    [Table("tRuntimeBufs")]
    internal class RuntimeBuf : IObservableElement, IBaseEntity
    {
        public int Id { get; set; }
        public Player Player { get; set; }
        public Buff Buff { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}

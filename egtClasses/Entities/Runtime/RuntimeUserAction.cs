using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace  egt.Classes.Entities
{
    [Table("tRuntimeUserActions")]
    internal class RuntimeUserAction : IObservableElement, IBaseEntity
    {
        public int Id { get; set; }
        public Player Player { get; set; }
        public RuntimeAction Action { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateFinish { get; set; }
        public bool IsFinished { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
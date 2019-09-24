using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace egt.Classes.Entities
{
    [Table("tReceipts")]
    internal class Receipt:IBaseEntity,IObservableElement
    {
        public int Id { get; set; }
        public Resource Name { get; set; }
        //public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
       // public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}

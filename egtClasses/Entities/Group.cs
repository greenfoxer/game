using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace egt.Classes.Entities
{
    [Table("tGroups")]
    internal class Group : IBaseEntity,IObservableElement
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
       // public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
       // public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
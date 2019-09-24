using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace egt.Classes.Entities
{
    [Table("tEquipments")]
    internal class Equipment:IBaseEntity,IObservableElement
    {
        public int Id  { get; set; }
        public int Attack  { get; set; }
        public int Defense  { get; set; }
        public int Honor  { get; set; }
        public int Extra { get; set; }
        public string Name  { get; set; }
        public string Description { get; set; }
       // public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        //public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public ICollection<Buff> Buffs { get; set; }
        public ICollection<Player> Players { get; set; }
        public Equipment()
        {
            Players = new List<Player>();
            Buffs = new List<Buff>();
        }

    }
}

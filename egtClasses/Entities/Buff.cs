using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace egt.Classes.Entities
{
    [Table("tBuffs")]
    internal class Buff : IBaseEntity,IObservableElement
    {
        public int Id  { get; set; }
        public int Attack  { get; set; }
        public int Honor { get; set; }
        public int Defense  { get; set; }
        public bool IsConstatant  { get; set; }
        public string Description  { get; set; }
        public string Name  { get; set; }
        public int Type { get; set; }
       // public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        //public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public ICollection<Player> Players { get; set; }
        public ICollection<Equipment> Equipments { get; set; }
        public Buff()
        {
            Players = new List<Player>();
            Equipments = new List<Equipment>();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace egt.Classes.Entities
{
    [Table("tPlayers")]
    internal class Player:IBaseEntity,IObservableElement
    {
        public int Health_max { get; set; }
        public int Stamina_max { get; set; }
        public int Extra_max { get; set; }
        public int Donation { get; set; }
        public int Cookie { get; set; }
        public int Carrying { get; set; }
        public int Stamina { get; set; }
        public int Extra { get; set; }
        public int Honor { get; set; }
        public int Health { get; set; }
        public int Defense { get; set; }
        public int Attack { get; set; }
        public int Level { get; set; }
        public int Experience { get; set; }
        public int Id { get; set; }
        public int Carrying_max { get; set; }
        public string Name { get; set; }
        public int TelegramID { get; set; }
        public bool IsApproved { get; set; }
        public bool IsActive { get; set; }
        public bool IsBusy { get; set; }
        internal Class PersonClass { get; set; }
        internal Group PersonGroup { get; set; }
        public DateTime? RegisterDate  { get; set; }
        public DateTime? LastActionDate { get; set; }
        //public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        //public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public ICollection<Buff> Buffs { get; set; }
        public ICollection<Equipment> Equipments { get; set; }
        public Player()
        {
            Buffs = new List<Buff>();
            Equipments = new List<Equipment>();
        }
        void DateUpdate()
        {
            this.LastActionDate = DateTime.Now;
        }   
        public void ChangeName(string newName)
        {
            this.Name = newName;
            DateUpdate();
        }
    }
}

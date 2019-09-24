using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace egt.Logic.DataTransferObjects
{
    public class PlayerInfo
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
        public ClassInfo PersonClass { get; set; }
        public GroupInfo PersonGroup { get; set; }
        public DateTime? RegisterDate  { get; set; }
        public DateTime? LastActionDate { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public ICollection<BuffInfo> Buffs { get; set; }
        public ICollection<EquipmentInfo> Equipments { get; set; }
        public PlayerInfo()
        {
            Buffs = new List<BuffInfo>();
            Equipments = new List<EquipmentInfo>();
            Health_max = Health = 300;
            Carrying_max = 1000;
            Extra_max = 0;
            Stamina_max = 4;
            IsActive = true;
            Level = 1;
        }
        public bool ChangeName(string newName)
        {
            if (Donation > 15)
            {
                this.Name = newName;
                return true;
            }
            return false;
        }
        public bool CureHealth()
        {
            if (Cookie > 0)
            {
                this.Health = this.Health_max;
                Cookie--;
                return true;
            }
            return false;
        }
    }
}

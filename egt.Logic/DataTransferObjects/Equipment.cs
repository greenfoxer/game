using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace egt.Logic.DataTransferObjects
{
    public class EquipmentInfo
    {
        public int Id  { get; set; }
        public int Attack  { get; set; }
        public int Defense  { get; set; }
        public int Honor  { get; set; }
        public int Extra { get; set; }
        public string Name  { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public ICollection<BuffInfo> Buffs { get; set; }
        public ICollection<PlayerInfo> Players { get; set; }
        public EquipmentInfo()
        {
            Players = new List<PlayerInfo>();
            Buffs = new List<BuffInfo>();
        }

    }
}

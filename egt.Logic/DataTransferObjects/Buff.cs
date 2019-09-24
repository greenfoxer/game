using System.Collections.Generic;
using System;

namespace egt.Logic.DataTransferObjects
{
    public class BuffInfo
    {
        public int Id  { get; set; }
        public int Attack  { get; set; }
        public int Honor { get; set; }
        public int Defense  { get; set; }
        public bool IsConstatant  { get; set; }
        public string Description  { get; set; }
        public string Name  { get; set; }
        public int Type { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public ICollection<PlayerInfo> Players { get; set; }
        public ICollection<EquipmentInfo> Equipments { get; set; }
        public BuffInfo()
        {
            Players = new List<PlayerInfo>();
            Equipments = new List<EquipmentInfo>();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EGTEntities
{
    public class Equipment
    {
        int id, attack,defense,honor,extra;
        string name, description;

        public int Id { get => id; set => id = value; }
        public int Attack { get => attack; set => attack = value; }
        public int Defense { get => defense; set => defense = value; }
        public int Honor { get => honor; set => honor = value; }
        public int Extra { get => extra; set => extra = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }

        public ICollection<Buff> Buffs { get; set; }
        public ICollection<Player> Players { get; set; }
        public Equipment()
        {
            Players = new List<Player>();
            Buffs = new List<Buff>();
        }

    }
}

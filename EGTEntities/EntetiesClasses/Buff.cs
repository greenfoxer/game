using System.Collections.Generic;

namespace EGTEntities
{
    public class Buff
    {
        int id, attack, honor, defense, type;
        bool isConstatant;
        string description, name;

        public int Id { get => id; set => id = value; }
        public int Attack { get => attack; set => attack = value; }
        public int Honor { get => honor; set => honor = value; }
        public int Defense { get => defense; set => defense = value; }
        public bool IsConstatant { get => isConstatant; set => isConstatant = value; }
        public string Description { get => description; set => description = value; }
        public string Name { get => name; set => name = value; }
        public int Type { get => type; set => type = value; }

        public ICollection<Player> Players { get; set; }
        public ICollection<Equipment> Equipments { get; set; }
        public Buff()
        {
            Players = new List<Player>();
            Equipments = new List<Equipment>();
        }
    }
}
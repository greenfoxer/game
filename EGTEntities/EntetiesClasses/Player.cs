using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EGTEntities
{
    public class Player
    {
        int id, experience, level, attack, defense, honor, extra, stamina, health, carrying, cookie, donation, extra_max, stamina_max, health_max, carrying_max;

        public int Health_max
        {
            get { return health_max; }
            set { health_max = value; }
        }

        public int Stamina_max
        {
            get { return stamina_max; }
            set { stamina_max = value; }
        }

        public int Extra_max
        {
            get { return extra_max; }
            set { extra_max = value; }
        }

        public int Donation
        {
            get { return donation; }
            set { donation = value; }
        }

        public int Cookie
        {
            get { return cookie; }
            set { cookie = value; }
        }

        public int Carrying
        {
            get { return carrying; }
            set { carrying = value; }
        }

        public int Stamina
        {
            get { return stamina; }
            set { stamina = value; }
        }

        public int Extra
        {
            get { return extra; }
            set { extra = value; }
        }

        public int Honor
        {
            get { return honor; }
            set { honor = value; }
        }

        public int Health
        {
            get { return health; }
            set { health = value; }
        }

        public int Defense
        {
            get { return defense; }
            set { defense = value; }
        }

        public int Attack
        {
            get { return attack; }
            set { attack = value; }
        }

        public int Level
        {
            get { return level; }
            set { level = value; }
        }

        public int Experience
        {
            get { return experience; }
            set { experience = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int Carrying_max
        {
            get { return carrying_max; }
            set { carrying_max = value; }
        }
        string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        string telegramID;

        public string TelegramID
        {
            get { return telegramID; }
            set { telegramID = value; }
        }
        bool isActive, isApproved, isBusy;

        public bool IsApproved
        {
            get { return isApproved; }
            set { isApproved = value; }
        }

        public bool IsActive
        {
            get { return isActive; }
            set { isActive = value; }
        }
        public bool IsBusy
        {
            get => isBusy;
            set => isBusy = value;
        }

        Class personClass;

        internal Class PersonClass
        {
            get { return personClass; }
            set { personClass = value; }
        }
        Group personGroup;

        internal Group PersonGroup
        {
            get { return personGroup; }
            set { personGroup = value; }
        }

        public DateTime RegisterDate { get => registerDate; set => registerDate = value; }
        public DateTime LastActionDate { get => lastActionDate; set => lastActionDate = value; }

        DateTime registerDate;
        DateTime lastActionDate;
        public ICollection<Buff> Buffs { get; set; }
        public ICollection<Equipment> Equipments { get; set; }

        public Player()
        {
            Buffs = new List<Buff>();
            Equipments = new List<Equipment>();
        }

        public Player(int id)
        {
            this.id = id;
            health = health_max = 300;
            stamina = stamina_max = 4;
            carrying_max = 1000;
            experience = level = attack = defense = honor = extra = carrying = cookie = donation = extra_max = 0;
            isActive = true;
            isApproved = false;
            personClass = Class.Newbie;
            personGroup = Group.Newbie;
            registerDate = DateTime.Now;
            DateUpdate();
        }
        public Player(int id, int experience, int level, int attack, int defense, int honor, int extra, int stamina, int health, int carrying, int cookie, int donation, int extra_max, int stamina_max, int health_max, int carrying_max)
        {
            this.id = id;
            this.health = health_max;
            this.health_max = health_max;
            this.stamina = stamina;
            this.stamina_max = stamina_max;
            this.carrying_max = carrying_max;
            this.experience = experience;
            this.level = level; this.attack = attack; this.defense = defense; this.honor = honor; this.extra = extra; this.carrying = carrying; this.cookie = cookie;
            this.donation = donation; this.extra_max = extra_max;
            this.isActive = true;
            this.isApproved = false;
            this.personClass = Class.Newbie;
            this.personGroup = Group.Newbie;
        }
        void DateUpdate()
        {
            this.lastActionDate = DateTime.Now;
        }   
        public void ChangeName(string newName)
        {
            this.name = newName;
            DateUpdate();
        }
    }
}

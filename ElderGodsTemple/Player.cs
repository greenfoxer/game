using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElderGodsTemple
{
    class Player
    {
        int id, experience, level, attack, defense, honor, extra, stamina, health, carrying, coockie, donation, extra_max, stamina_max, health_max, carrying_max;
        string name;
        string telegramID;
        bool isActive, isApproved;
        Class personClass;
        Group personGroup;

        public Player(int id)
        {
            this.id = id;
            health = health_max = 300;
            stamina = stamina_max = 4;
            carrying_max = 1000;
            experience = level = attack = defense = honor = extra = carrying = coockie = donation = extra_max = 0;
            isActive = true;
            isApproved = false;
            personClass = Class.Newbie;
            personGroup = Group.Newbie;
        }
    }
}

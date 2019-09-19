using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ElderGodsTemple
{
    class Group
    {
        int id;
        string name, description;

        public Group(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        //Default
        public static Group Newbie = new Group(0,"Безбожник");
    }
}

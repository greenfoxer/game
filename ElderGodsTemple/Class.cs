using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ElderGodsTemple
{
    class Class
    {
        int id;
        string name, description;

        public Class(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        //Default
        public static Class Newbie = new Class(0,"Безбожник");
    }
}

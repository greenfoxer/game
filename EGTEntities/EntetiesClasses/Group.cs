using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EGTEntities
{
    public class Group
    {
        int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        string name, description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        bool isActive;

        public bool IsActive
        {
            get { return isActive; }
            set { isActive = value; }
        }

        public Group(int id, string name, bool isActive, string description = "")
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.isActive = isActive;
        }
        //Default
        public static Group Newbie = new Group(0,"Безбожник",true);
    }
}

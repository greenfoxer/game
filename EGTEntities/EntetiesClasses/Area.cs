using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EGTEntities
{
    public class Area
    {
        int id, level;

        public int Level
        {
            get { return level; }
            set { level = value; }
        }

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
        public Area(int id, string name, bool isActive, int level, string description = "")
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.isActive = isActive;
            this.level = level;
        }
        //default
        public static Area Center = new Area(0, "Городская площадь", true, 0);
    }
}

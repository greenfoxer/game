using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EGTEntities
{
    public class ResourceType
    {
        int id, name;

        public int Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
    }
}

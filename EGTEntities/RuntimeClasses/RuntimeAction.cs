using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EGTEntities
{
    public class RuntimeAction
    {
        int id, priority;
        string description;

        public int Id { get => id; set => id = value; }
        public string Description { get => description; set => description = value; }
        public int Priority { get => priority; set => priority = value; }
    }
}

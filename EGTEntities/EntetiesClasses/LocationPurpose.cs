using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EGTEntities
{
    public class LocationPurpose
    {
        int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        string purpose;

        public string Purpose
        {
            get { return purpose; }
            set { purpose = value; }
        }
    }
}

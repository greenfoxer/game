using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EGTEntities
{
    public class Location
    {
        int id, duration_base, requirement_stamina;

        public int Requirement_stamina
        {
            get { return requirement_stamina; }
            set { requirement_stamina = value; }
        }

        public int Duration_base
        {
            get { return duration_base; }
            set { duration_base = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        bool isConstant, isActive;

        public bool IsActive
        {
            get { return isActive; }
            set { isActive = value; }
        }

        public bool IsConstant
        {
            get { return isConstant; }
            set { isConstant = value; }
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
        LocationPurpose purpose;

        public LocationPurpose Purpose
        {
            get { return purpose; }
            set { purpose = value; }
        }
        public Location(int id, int duration_base, int requirement_stamina,bool isConstant, LocationPurpose purpose, bool isActive,string name, string description="")
        { 
            this.id = id;
            this.duration_base = duration_base;
            this.requirement_stamina = requirement_stamina;
            this. isConstant = isConstant;
            this. purpose = purpose;
            this.isActive = isActive;
            this.name = name;
            this.description = description;
        }
    }
}

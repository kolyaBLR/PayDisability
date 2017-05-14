using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayDisability
{
    struct Employes
    {
        private string Name;
        private float Salary;
        private int Experience;

        public string name { get { return Name; } }
        public float salary { get { return Salary; } }
        public int experience { get { return Experience; } }

        public Employes(string _name, float _salary, int _experience)
        {
            Name = _name;
            Salary = _salary;
            Experience = _experience;
        }
    }
}

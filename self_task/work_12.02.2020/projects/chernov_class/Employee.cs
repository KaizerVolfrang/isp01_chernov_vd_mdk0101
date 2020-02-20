using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chernov_Gladskih_ISP_1
{
    class Employee
    {
        private string Name
        { get; set;}

        private string Profession
        { get; set; }

        private int WorkExperience
        { get; set; }

        public Employee(string name, string profession, int workexperiencer)
        {
            Name = name;
            Profession = profession;
            WorkExperience = workexperiencer;
        }

        public override string ToString()
        {
            return ($" Employee: {Name}, {Profession}, {WorkExperience} ");
        }
    }
}

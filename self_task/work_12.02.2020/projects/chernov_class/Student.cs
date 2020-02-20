using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chernov_Gladskih_ISP_1
{
    class Student
    {
        private string Name
        {get; set;}

        private int Curse
        {get; set;}

        public readonly string Gender;

        public Student(string name, int curse, string gender)
        {
            Name = name;
            Curse = curse;
            Gender = gender;
        }
        public override string ToString()
        {
            return ($" Student: {Name}, {Curse}, {Gender}");
        }
    }
}

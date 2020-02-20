using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chernov_Gladskih_ISP_1
{
    class StudyGroup
    {
        private string Cipher
        { get; set; }

        private int NumberStudents
        { get; set; }

        private int YearFormation
        { get; set; }

        private string Specialty
        { get; set; }

        public StudyGroup(string cipher, int numberStudents, int yearFormation, string specialty)
        {
            Cipher = cipher;
            NumberStudents = numberStudents;
            YearFormation = yearFormation;
            Specialty = specialty;
        }
        public override string ToString()
        {
            return ($" StudyGroup: {Cipher}, {NumberStudents}, {YearFormation}, {Specialty}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chernov_Gladskih_ISP_1
{
    class Record
    {
        private string NameTestSubject
        { get; set; }

        private string NameExaminer
        { get; set; }

        private DateTime Date
        { get; set; }

        private int Grade
        { get; set; }

        public Record(string nameTestSubject, string nameExaminer, DateTime date, int grade)
        {
            NameTestSubject = nameTestSubject;
            NameExaminer = nameExaminer;
            Date = date;
            Grade = grade;
        }
        public override string ToString()
        {
            return ($" Record: {NameTestSubject}, {NameExaminer}, {Date}, {Grade}");
        }
    }
}

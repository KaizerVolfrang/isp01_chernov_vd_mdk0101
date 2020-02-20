using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chernov_Gladskih_ISP_1
{
    class Workshop
    {
        private string StringCipher
        { get; set; }

        private int NumberOfEmployees
        { get; set; }

        public Workshop(string stringCipher, int numberOfEmployees)
        {
            StringCipher = stringCipher;
            NumberOfEmployees = numberOfEmployees;
        }
        public override string ToString()
        {
            return ($" Workshop: {StringCipher}, {NumberOfEmployees}");
        }
    }
}

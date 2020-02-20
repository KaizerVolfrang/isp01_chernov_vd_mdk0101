using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chernov_Gladskih_ISP_1
{
    class Product
    {
        private string Name
        { get; set; }

        private int Number
        { get; set; }

        private int Cost
        { get; set; }

        private int ExpirationDate
        { get; set; }

        public Product(string name, int number, int cost, int expirationDate)
        {
            Name = name;
            Number = number;
            Cost = cost;
            ExpirationDate = expirationDate;
        }

        public override string ToString()
        {
            return ($" Product: {Name}, {Number}, {Cost}, {ExpirationDate}");
        }
    }
}

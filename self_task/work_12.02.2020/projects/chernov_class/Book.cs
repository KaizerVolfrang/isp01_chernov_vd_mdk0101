using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chernov_Gladskih_ISP_1
{
    class Book
    {
        private string Name
        { get; set; }

        private string[] ListAuthorsNames
        { get; set; }

        private int Cost
        { get; set; }

        public Book(string name, string[] listAuthorsNames, int cost)
        {
            Name = name;
            ListAuthorsNames = listAuthorsNames;
            Cost = cost;
        }
        public override string  ToString()
        {
            return ($" Book: {Name}, {ListAuthorsNames}, {Cost}");
        }
    }
}

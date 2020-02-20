using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chernov_Gladskih_ISP_1
{
    class ComputerGame
    {
        private string Name
        { get; set; }

        private string CompanyDeveloper
        { get; set; }

        private int YearPublishing
        { get; set; }

        private string Genre
        { get; set; }

        public ComputerGame(string name, string companyDeveloper, int yearPublishing, string genre)
        {
            Name = name;
            CompanyDeveloper = companyDeveloper;
            YearPublishing = yearPublishing;
            Genre = genre;
        }

        public override string ToString()
        {
            return ($" ComputerGame: {Name}, {CompanyDeveloper}, {YearPublishing}, {Genre}");
        }
    }
}

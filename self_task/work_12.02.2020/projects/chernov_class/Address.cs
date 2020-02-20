using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chernov_Gladskih_ISP_1
{
    class Address
    {
        private int Postcode
        { get; set; }

        private string Town
        { get; set; }

        private string Street
        { get; set; }

        private int House
        { get; set; }

        private int Apartment
        { get; set; }

        public Address(int postcode, string town, string street, int house, int apartment)
        {
            Postcode = postcode;
            Town = town;
            Street = street;
            House = house;
            Apartment = apartment;
        }

        public override string ToString()
        {
            return ($" Address: {Postcode}, {Town}, {Street}, {House}, {Apartment}");
        }
    }
}

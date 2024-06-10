using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6._1._1
{
    internal class HouseNode
    {
        public int HouseNumber { get; set; }
        public string HouseType { get; set; }
        public string Address { get; set; }
        public HouseNode Next { get; set; }

        public HouseNode(int houseNumber, string houseType, string address)
        {
            HouseNumber = houseNumber;
            HouseType = houseType;
            Address = address;
        }
    }
}

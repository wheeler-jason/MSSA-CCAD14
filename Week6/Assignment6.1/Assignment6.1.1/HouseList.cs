using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6._1._1
{
    // This class represents a singly linked list of HouseNodes
    internal class HouseList
    {
        private HouseNode _head;
        private HouseNode _tail;

        public void AddHouse(int houseNumber, string houseType, string address)
        {
            HouseNode newHouse = new HouseNode(houseNumber, houseType, address);

            // if the list is empty, set the head and tail to the new house
            if (_head == null)
            {
                _head = newHouse;
                _tail = newHouse;
            }
            // if the list is not empty, add the new house to the end of the list
            else
            {
                // update the old tail's Next pointer to point to the new house
                _tail.Next = newHouse;

                // make the new house the new tail
                _tail = newHouse;
            }
        }

        public void SearchHouse(int houseNumber)
        {
            HouseNode current = _head;
            while (current != null)
            {
                if (current.HouseNumber == houseNumber)
                {
                    Console.WriteLine("House found:");
                    PrintHouse(current);
                    return;
                }
                current = current.Next;
            }
            Console.WriteLine("House not found");
        }

        public void PrintHouse(HouseNode house) 
        {
            Console.WriteLine($"House Number: {house.HouseNumber}, House Type: {house.HouseType}, Address: {house.Address}"); 
        }

    }
}

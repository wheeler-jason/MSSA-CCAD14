using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7._4
{
    public class ParkingSystem
    {
        private int[] spots = new int[4];

        public ParkingSystem(int big, int medium, int small)
        {
            spots[1] = big;
            spots[2] = medium;
            spots[3] = small;
        }

        public bool AddCar(int carType)
        {
            switch (carType)
            {
                case 1:
                    if (spots[1] > 0)
                    {
                        spots[1]--;
                        return true;
                    }
                    break;
                case 2:
                    if (spots[2] > 0)
                    {
                        spots[2]--;
                        return true;
                    }
                    break;
                case 3:
                    if (spots[3] > 0)
                    {
                        spots[3]--;
                        return true;
                    }
                    break;
                default:
                    return false;
            }

            return false;
        }
    }
}

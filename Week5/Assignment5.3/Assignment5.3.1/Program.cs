namespace Assignment5._3._1
{
    /*
     * You have a long flowerbed in which some of the plots are planted, and some are not. 
     * However, flowers cannot be planted in adjacent plots.
     * Given an integer array flowerbed containing 0's and 1's, 
     * where 0 means empty and 1 means not empty, and an integer n, 
     * return true if n new flowers can be planted in the flowerbed without 
     * violating the no-adjacent-flowers rule and false otherwise.
     * Example 1:
     * Input: flowerbed = [1,0,0,0,1], n = 1
     * Output: true
     * Example 2:
     * Input: flowerbed = [1,0,0,0,1], n = 2
     * Output: false
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] testFlowerBed = [0, 0, 1, 0, 0];
            Console.WriteLine(PlantNonAdjacentFlowers(testFlowerBed, 1));
        }

        public static bool PlantNonAdjacentFlowers(int[] flowerbed, int n)
        {
            int i = 0;
            int flowersPlantedCounter = 0;

            // if there is only a single zero in the array
            if (flowerbed.Length == 1 && n == 1 && flowerbed[0] == 0 )
            {
                return true;
            }

            while (i < flowerbed.Length)
            {
                if (flowerbed[i] == 0)
                {
                    // if we're at the start of the array
                    if (i == 0)
                    {
                        // if the next element is also a 0, then plant the flower
                        if (flowerbed[i + 1] == 0)
                        {
                            flowerbed[i] = 1;
                            flowersPlantedCounter++;
                            i++;
                        }
                        else
                        {
                            i++;
                        }
                    }
                    // if we're at the end of the array
                    else if (i == flowerbed.Length-1)
                    {
                        // if the previous element is also a 0, then plant the flower
                        if (flowerbed[i-1] == 0)
                        {
                            flowerbed[i] = 1;
                            flowersPlantedCounter++;
                            i++;
                        }
                        else
                        {
                            i++;
                        }
                    }
                    // if we're in the middle of the array
                    else if (i > 0 && i < flowerbed.Length-1)
                    {
                        // if we have zeroes on both sides
                        if (flowerbed[i-1] == 0 && flowerbed[i+1] == 0)
                        {
                            flowerbed[i] = 1;
                            flowersPlantedCounter++;
                            i++;
                        } 
                        else
                        {
                            i++;
                        }
                    }
                }
                else
                {
                    i++;
                }
            }

            return flowersPlantedCounter >= n;
        }
    }
}

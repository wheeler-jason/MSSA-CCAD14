﻿namespace Assignment5._3._1
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
            int[] testFlowerBed = [0];
            Console.WriteLine(CanPlaceFlowers(testFlowerBed, 0));
        }

        public static bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            int count = 0;

            for (int i = 0; i < flowerbed.Length; i++)
            {
                // Check if the current plot is empty.
                if (flowerbed[i] == 0)
                {
                    // Check if the left and right plots are empty.
                    bool emptyLeftPlot = (i == 0) || (flowerbed[i - 1] == 0);
                    bool emptyRightPlot = (i == flowerbed.Length - 1) || (flowerbed[i + 1] == 0);

                    // If both plots are empty, we can plant a flower here.
                    if (emptyLeftPlot && emptyRightPlot)
                    {
                        flowerbed[i] = 1;
                        count++;
                    }
                }
            }
            return count >= n;
        }
    }
}

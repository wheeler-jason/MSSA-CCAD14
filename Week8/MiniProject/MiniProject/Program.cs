namespace MiniProject
{
    /*
     * 253. Meeting Rooms II
     * Given an array of meeting time intervals, intervals, where 
     * intervals[i] = [starti, endi], return the minimum number of conference rooms required.
     * 
     * Example 1:
     * Input: intervals = [[0,30],[5,10],[15,20]]
     * Output: 2
     *
     * Example 2:
     * Input: intervals = [[7,10],[2,4]]
     * Output: 1
     * 
     * Constraints:
     * 1 <= intervals.length <= 104
     * 0 <= starti < endi <= 106
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public static int MinMeetingRooms(int[][] intervals)
        {
            // separate the start and end times into two separate arrays
            int[] startTimes = new int[intervals.Length];
            int[] endTimes = new int[intervals.Length];
            for (int i = 0; i < intervals.Length; i++)
            {
                startTimes[i] = intervals[i][0];
                endTimes[i] = intervals[i][1];
            }

            // sort the start and end times
            Array.Sort(startTimes);
            Array.Sort(endTimes);

            // user two pointer technique to iterate through the
            // intervals and keep track of the number of rooms needed
            int startPointer = 0;
            int endPointer = 0;
            int currentRoomCount = 0;
            int maxRoomCount = 0;

            while (startPointer < intervals.Length)
            {
                if (startTimes[startPointer] < endTimes[endPointer])
                {
                    currentRoomCount++;
                    maxRoomCount = Math.Max(maxRoomCount, currentRoomCount);
                    startPointer++;
                }
                else
                {
                    currentRoomCount--;
                    endPointer++;
                }
            }

            return maxRoomCount;
        }
    }
}

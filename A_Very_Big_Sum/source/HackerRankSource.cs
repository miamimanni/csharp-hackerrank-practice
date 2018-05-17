using System;
using System.Linq;

namespace HackerRank
{
    public class Solution
    {
        /// <summary>
        /// Sums all values in an array
        /// </summary>
        /// <param name="arrayToSum">array containing all values to sum together, values are of data type long</param>
        /// <returns>sum based on the input array arrayToSum, return data type is long</returns>
        public static long aVeryBigSum(long[] arrayToSum){
            return arrayToSum.Sum();
        }

        static void Main(string[] args)
        {
            // Discard first line
            Console.ReadLine();
            long[] largeNumberArray = 
                Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt64(arTemp));
            long result = aVeryBigSum(largeNumberArray);
            Console.WriteLine(result);
        }
    }
}

using System;
using System.Linq;

namespace HackerRank
{
    public class Solution
    {
        /// <summary>
        /// Sums all values in an array
        /// </summary>
        /// <param name="arrayToSum">int array containing all values to sum together</param>
        /// <returns>integer representation of sum based on the input array arrayToSum</returns>
        public static int SimpleArraySum(int[] arrayToSum){
            return arrayToSum.Sum();
        }

        static void Main(string[] args)
        {
            int arCount = Convert.ToInt32(Console.ReadLine());
            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
            int result = SimpleArraySum(ar);
            Console.WriteLine(result);
        }
    }
}

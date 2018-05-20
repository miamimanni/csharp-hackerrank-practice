using System;
using System.Linq;

namespace HackerRank
{
    public class Solution
    {
        /// <summary>
        /// Sums diagonals in multidimensional grid and returns the differences of those sums
        /// </summary>
        /// <param name="a">multidimensional array representing a grid of integers</param>
        /// <returns>int value difference of diagonal sums</returns>
        public static int diagonalDifference(int[][] a){
            int positiveDiagonalSum = 0;
            int negativeDiagonalSum = 0;
            for(int i = 0; i < a.Length; i++){
                positiveDiagonalSum += a[i][i];
                negativeDiagonalSum += a[i][a.Length - 1- i];
            }
            return Math.Abs(positiveDiagonalSum - negativeDiagonalSum);
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[][] a = new int[n][];

            for (int i = 0; i < n; i++) {
                a[i] = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));
            }

            int result = diagonalDifference(a);

            Console.WriteLine(result);
        }
    }
}

using System;
using System.Linq;

namespace HackerRank
{
    public class Solution
    {
        /// <summary>
        /// Determines fraction of positive, negative and zero values
        /// </summary>
        /// <param name="a">integer array to evaluate</param>
        /// <returns>float array consisting decimal fraction values for [postive, negative, zero]</returns>
        public static double[] plusMinus(int[] arrayToEvaluate){
            if(arrayToEvaluate.Length == 0)
                return new double[]{0.0d, 0.0d, 0.0d};

            double positiveCounter = 0;
            double negativeCounter = 0;
            double zeroCounter     = 0;

            foreach(int value in arrayToEvaluate){
                positiveCounter += value > 0  ? 1 : 0;
                negativeCounter += value < 0  ? 1 : 0;
                zeroCounter     += value == 0 ? 1 : 0;
            }

            double positiveRatio = positiveCounter / arrayToEvaluate.Length;
            double negativeRatio = negativeCounter / arrayToEvaluate.Length;
            double zeroRatio     = zeroCounter     / arrayToEvaluate.Length;

            return new double[]{positiveRatio, negativeRatio, zeroRatio};
        }

        static void Main(string[] args)
        {
            // Discard first line
            // Console.ReadLine();

            // int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            // int[] arr = new int[]{-4, 3, -9, 0, 4, 1};
            int[] arr = new int[]{};
            double[] result = plusMinus(arr);

            Console.WriteLine(String.Join("\n", result));
        }
    }
}

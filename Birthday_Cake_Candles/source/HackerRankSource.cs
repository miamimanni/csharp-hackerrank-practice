using System;
using System.Text;

namespace HackerRank
{
    public class Solution
    {
        /// <Summary>
        /// Finds count of the heightest candles
        /// </Summary>
        /// <param name="candleHeights">integer array, where each element represents height of a candle</param>
        /// <returns>count of highest candles</returns>
        public static int BirthdayCakeCandles(int[] candleHeights)
        {
            int highestCandle = 0;
            int countOfHighestCandle = 0;
            
            foreach(int candleHeight in candleHeights)
            {
                if(candleHeight > highestCandle)
                {
                    highestCandle = candleHeight;
                    countOfHighestCandle = 0;
                }
                
                countOfHighestCandle += candleHeight == highestCandle ? 1 : 0;
            }

            return countOfHighestCandle;
        }

        static void Main(string[] args)
        {
            // Discard first line
            Console.ReadLine();

            int[] candleHeights = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
            int result = BirthdayCakeCandles(candleHeights);

            Console.WriteLine(result);
        }
    }
}

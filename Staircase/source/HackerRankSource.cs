using System;
using System.Text;

namespace HackerRank
{
    public class Solution
    {
        public static string Staircase(int countOfStairs)
        {
            StringBuilder outputBuffer = new StringBuilder();
            for(int i = 1; i <= countOfStairs; i++)
            {
                outputBuffer.AppendLine(string.Empty.PadRight(countOfStairs - i, ' ') + string.Empty.PadRight(i, '#'));
            }

            return outputBuffer.ToString().TrimEnd();
        }

        static void Main(string[] args)
        {
            int countOfStairs = Convert.ToInt32(Console.ReadLine());
            string result = Staircase(countOfStairs);
            Console.Write(result);
        }
    }
}

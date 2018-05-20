using System;
using System.Linq;

namespace HackerRank
{
    public class Solution
    {
        /// <summary>
        /// Process points Alice and Bob has, then calculates a score for them
        /// </summary>
        /// <param name="alicePoints">integer value representing points bob has</param>
        /// <param name="bobPoints">integer value representing points alice has</param>
        /// <returns>integer array holding alice's score and bob's score</returns>
        public static int[] calculateBobAndAliceScores(int[] alicePoints, int[] bobPoints)
        {
            int aliceScore = 0;
            int bobScore = 0;

            for(int i = 0; i < alicePoints.Length; i++)
            {
                aliceScore += alicePoints[i] > bobPoints[i] ? 1 : 0 ;
                bobScore   += alicePoints[i] < bobPoints[i] ? 1 : 0 ;
            }

            return new int[]{aliceScore, bobScore};
        }

        static void Main(string[] args)
        {
            int[] alicePoints = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
            int[] bobPoints = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
            int[] results = calculateBobAndAliceScores(alicePoints, bobPoints);
            Console.WriteLine(string.Join(" ", results));
        }
    }
}

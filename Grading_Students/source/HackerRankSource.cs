using System;
using System.Linq;

namespace HackerRank
{
    public class Solution
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public static int[] gradingStudents(int[] grades) {
            var roundedUpGrades = new int[grades.Length];
            for(int i = 0; i < grades.Length; i++)
                roundedUpGrades[i] = roundUpGrade(grades[i]);
            return roundedUpGrades;
        }
        
        private static int roundUpGrade(int inputGrade){
            if(inputGrade < 37)
                return inputGrade;
            int roundUpFactor = 5 - inputGrade % 5;
            roundUpFactor = roundUpFactor == 5 ? 0 : roundUpFactor;
            return roundUpFactor < 3 ? inputGrade + roundUpFactor : inputGrade;
        }

        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] grades = new int [n];

            for (int gradesItr = 0; gradesItr < n; gradesItr++) {
                int gradesItem = Convert.ToInt32(Console.ReadLine());
                grades[gradesItr] = gradesItem;
            }

            int[] result = gradingStudents(grades);

            Console.WriteLine(string.Join("\n", result));
        }
    }
}

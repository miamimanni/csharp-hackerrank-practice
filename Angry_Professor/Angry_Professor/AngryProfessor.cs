using System;

namespace Angry_Professor
{
    public class AngryProfessor
    {
        /// <summary>
        /// Determines if class is cancelled for angry profressor's class. If minimum threshold of students don't arrive to class in time, professor responds w/ Yes or No.
        /// </summary>
        /// <param name="minimumOntimeOrEarlyStudentsNeededForClass">integer value representing number of minimum students needed to attend class, otherwise class is cancelled</param>
        /// <param name="studentArrivalTimes">integer array representing time student arrival. 0 is on time, less than 0 is early, after 0 is late.</param>
        /// <returns>boolean value, true if class is cancelled, false if class is not cancelled</returns>
        public static bool IsClassCancelled(int minimumOntimeOrEarlyStudentsNeededForClass, int[] studentArrivalTimes)
        {
            int countOfEarlyAndOnTimeStudents = 0;
            foreach (int studentArrivalTime in studentArrivalTimes)
            {
                if (studentArrivalTime <= 0)
                {
                    countOfEarlyAndOnTimeStudents++;
                    if (countOfEarlyAndOnTimeStudents == minimumOntimeOrEarlyStudentsNeededForClass)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        static void Main(string[] args)
        {
            int amountOfClasses = Convert.ToInt32(Console.ReadLine());

            for (int classNumber = 0; classNumber < amountOfClasses; classNumber++)
            {
                int thresholdOfStudentsNeededForClass = Convert.ToInt32(Console.ReadLine().Split(' ')[1]);
                int[] studentArrivalTimes = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);
                bool result = IsClassCancelled(thresholdOfStudentsNeededForClass, studentArrivalTimes);
                Console.WriteLine(result ? "YES" : "NO");
            }
        }
    }
}

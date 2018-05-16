using System;
using System.Linq;

namespace HackerRank
{
    public class Solution
    {
        /// <summary>
        /// Converts non-military time to military time
        /// </summary>
        /// <param name="nonMilitaryTime">String representation of non-military time, formatted in following fashion "hh:mm:dd:AM" or "hh:mm:dd:PM"</param>
        /// <returns>String representation of military time based on input</returns>
        public static string TimeConversion(string nonMilitaryTime){
            int hours = Int32.Parse(nonMilitaryTime.Substring(0, 2));
            // Get middle (minutes and seconds along with colon) ":mm:ss"
            string middle = nonMilitaryTime.Substring(2, 6);
            bool isAfternoon = string.Equals(nonMilitaryTime.Substring(8, 2), "pm", StringComparison.OrdinalIgnoreCase);
            // Determine new hours
            string newHours = (isAfternoon ? (hours == 12 ? hours : hours + 12) : (hours == 12 ? 0 : hours)).ToString("00");
            // determine prefix, if pm, add 12 to hours, otherwise just return hours.
            // return prefix and middle
            return $"{newHours}{middle}";
        }

        static void Main(string[] args)
        {
            string nonMilitaryTime = Console.ReadLine();
            string result = TimeConversion(nonMilitaryTime);
            Console.WriteLine(result);
        }
    }
}

using System;

namespace HackerRank
{
    public class Solution
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public static int[] countApplesAndOranges(int samHouseStart, int samHouseEnd, int appleTreeLocation, int orangeTreeLocation, int[] apples, int[] oranges) {
            const int countOfFruitsAndTrees = 2;
            int[] countOfFruits = new int[]{0, 0};
            int[] treeLocations = new int[]{appleTreeLocation, orangeTreeLocation};
            int[][] fruitLocations = new int[][]{apples, oranges};
            
            for(int i = 0; i < countOfFruitsAndTrees; i++){
                for(int j = 0; j < fruitLocations[i].Length; j++){
                    if(isOnSamsHouse(treeLocations[i], samHouseStart, samHouseEnd, fruitLocations[i][j])){
                        countOfFruits[i]++;
                    }
                }
            }

            return countOfFruits;
        }

        private static bool isOnSamsHouse(int treeLocation, int samHouseStart, int samHouseEnd, int distanceFromTree){
            int positionOfFruit = treeLocation + distanceFromTree;
            return samHouseStart <= positionOfFruit && positionOfFruit <= samHouseEnd;
        }

        static void Main(string[] args) {
            const int appleResultIndex = 0;
            const int orangeResultIndex = 1;
            string[] sameHouseRange = Console.ReadLine().Split(' ');
            int samHouseStart = Convert.ToInt32(sameHouseRange[0]);
            int samHouseEnd = Convert.ToInt32(sameHouseRange[1]);
            
            string[] treeLocations = Console.ReadLine().Split(' ');
            int treeALocation = Convert.ToInt32(treeLocations[0]);
            int treeBLocation = Convert.ToInt32(treeLocations[1]);
            
            // string[] amountOfApplesAndOranges = Console.ReadLine().Split(' ');
            // int amountOfApples = Convert.ToInt32(amountOfApplesAndOranges[0]);
            // int amountOfOranges = Convert.ToInt32(amountOfApplesAndOranges[1]);
            Console.ReadLine(); // Discard line, not used
            int[] apples = Array.ConvertAll(Console.ReadLine().Split(' '), applesTemp => Convert.ToInt32(applesTemp));
            int[] oranges = Array.ConvertAll(Console.ReadLine().Split(' '), orangesTemp => Convert.ToInt32(orangesTemp));
            
            int[] results = countApplesAndOranges(samHouseStart, samHouseEnd, treeALocation, treeBLocation, apples, oranges);
            Console.WriteLine(results[appleResultIndex]);
            Console.WriteLine(results[orangeResultIndex]);
        }
    }
}

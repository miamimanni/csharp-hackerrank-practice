using System;
// using System.Linq;

namespace HackerRank
{
    public class Solution
    {
        /// <summary>
        /// Finds mini max of array such that if your have 5 elements, will return sum of lowest 4 elements and return sum of highest 4 elements
        /// </summary>
        /// <param name="arrayToSum">array containing all values to sum together, values are of data type long</param>
        /// <returns>sum based on the input array arrayToSum, return data type is long</returns>
        public static long[] miniMaxSum(long[] arrayToSum)
        {
            bubbleSort(arrayToSum);
            // Array.Sort(arrayToSum);
            long lowSum = 0;
            long highSum = 0;
            for(int i = 0; i < arrayToSum.Length; i++)
            {
                highSum += i > 0                     ? arrayToSum[i] : 0;
                lowSum  += i < arrayToSum.Length - 1 ? arrayToSum[i] : 0;
            }
    
            return new long[]{lowSum, highSum};
        }

        static void Main(string[] args)
        {
            //long[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt64(arrTemp));
            long[] arr = Array.ConvertAll("2 3 4 5 1".Split(' '), arrTemp => Convert.ToInt64(arrTemp));
            long[] result = miniMaxSum(arr);
            Console.WriteLine($"{result[0]} {result[1]}");
        }

        private static void bubbleSort(long[] arrayToSort)
        {
            // if(arrayToSort.Length < 2)
            // {
            //     return;
            // }
            
            var isSorted = false;
            for(int i = arrayToSort.Length; isSorted == false && i > 0; i--)
            {
                isSorted = true;
                for(int j = 0; j + 1 < i; j++)
                {
                    if(arrayToSort[j] > arrayToSort[j+1])
                    {
                        swap(arrayToSort, j, j+1);
                        isSorted = false;
                    }
                }
            }
        }

        private static void swap(long[] arrayToSwapElements, int elementIndex1, int elementIndex2)
        {
            long temp = arrayToSwapElements[elementIndex1];
            arrayToSwapElements[elementIndex1] = arrayToSwapElements[elementIndex2];
            arrayToSwapElements[elementIndex2] = temp;
        }
    }
}

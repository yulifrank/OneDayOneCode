using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneDayOneCode.problems
{
    internal class LongestIncreasingSubsequence
    {

        public static int FindLISLengthRec(int[] nums, int index,int prevNumber)
        {
            if (index <=-1)
                return 0;
            if (nums[index] <= prevNumber)
                return Math.Max(1+FindLISLengthRec(nums, index-1, nums[index]), FindLISLengthRec(nums, index - 1, prevNumber));
            return FindLISLengthRec(nums, index - 1, prevNumber);


        }
        internal class Program
        {
            static void Main(string[] args)
            {
                int[] arr = {1,3,2,3,4,2,5,19,9,14};
                int result = LongestIncreasingSubsequence.FindLISLengthRec(arr, arr.Length - 1, int.MaxValue);
                Console.WriteLine("Length of LIS: " + result);
            }
        }
    }
}

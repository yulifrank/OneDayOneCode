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

        public static int FindLISLength(int[] nums)
        {
            int[] maxResultArrayWith = new int[nums.Length];
            int[] maxResultArrayWithout = new int[nums.Length];
            maxResultArrayWith[0] = 1;

            for (int i = 1; i < nums.Length; i++)
            {
                for (int j = 0; j < i ; j++)
                {
                    if ((nums[i] >= nums[j]))
                        maxResultArrayWith[i] = Math.Max(1 + maxResultArrayWith[j], maxResultArrayWith[i]);
                    maxResultArrayWithout[i] = Math.Max(maxResultArrayWith[j], maxResultArrayWithout[i]);

                } 
            }

            return Math.Max(maxResultArrayWith[nums.Length - 1], maxResultArrayWithout[nums.Length - 1]);

        }
        internal class Program
        {
            static void Main(string[] args)
            {
                int[] arr = {2,4,8,3,6,2,5,3,8,4};
             
                int result = LongestIncreasingSubsequence.FindLISLengthRec(arr, arr.Length - 1, int.MaxValue);
                Console.WriteLine("Length of LIS: " + result);
                result = LongestIncreasingSubsequence.FindLISLength(arr);
                Console.WriteLine("Length of LIS: " + result);
            }
        }
    }
}

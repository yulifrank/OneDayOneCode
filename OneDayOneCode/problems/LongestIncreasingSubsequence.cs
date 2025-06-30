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
            if (nums.Length ==0) return 0;
            int[] maxResultArrayWith = new int[nums.Length];

            for (int i = 0; i < maxResultArrayWith.Length; i++)
            {
                maxResultArrayWith[i] = 1;
            }

            for (int i = 1; i < nums.Length; i++)
            {
                for (int j = 0; j < i ; j++)
                {
                    if ((nums[i] >= nums[j]))
                        maxResultArrayWith[i] = Math.Max(1 + maxResultArrayWith[j], maxResultArrayWith[i]);

                } 
            }

            return maxResultArrayWith.Max();

        }
        public static int FindLISLengthV1(int[] nums)
        {
            if (nums.Length == 0) return 0;
            int[] maxResultArrayWith = new int[nums.Length];
            int[] maxResultArrayWithout = new int[nums.Length];
            maxResultArrayWith[0] = 1;

            for (int i = 1; i < nums.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if ((nums[i] >= nums[j]))
                        maxResultArrayWith[i] = Math.Max(1 + maxResultArrayWith[j], maxResultArrayWith[i]);
                    maxResultArrayWithout[i] = Math.Max(maxResultArrayWith[j], maxResultArrayWithout[i]);

                }
            }

            return Math.Max(maxResultArrayWith[nums.Length - 1], maxResultArrayWithout[nums.Length - 1]);

        }


    }
}

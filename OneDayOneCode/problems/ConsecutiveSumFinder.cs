using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneDayOneCode.problems
{
    internal class ConsecutiveSumFinder
    {
        public static int FindCountConsecutiveSequencesRec(int[] array, int startIndex, int endIndex, int remaining)
        {
            if (startIndex >= array.Length || endIndex >= array.Length)
                return 0;
            int count = 0;
            if (array[endIndex] == remaining)
                count++;
            count += FindCountConsecutiveSequencesRec(array, startIndex, endIndex + 1, remaining - array[endIndex]);
            if (startIndex == endIndex)
                count += FindCountConsecutiveSequencesRec(array, startIndex + 1, startIndex + 1, remaining);

            return count;
        }


        public static int FindCountConsecutiveSequences(int[] array,int target)
        {
            Dictionary<int, int> sumsCounts = new Dictionary<int, int>();
            sumsCounts[0] = 1; 

            int sum  = 0;
            int count = 0;
            for (int i = 0;i<array.Length;i++)
            {
                sum += array[i];
    
                if (sumsCounts.ContainsKey(sum - target))
                    count += sumsCounts[sum - target];
                if (sumsCounts.ContainsKey(sum))
                    sumsCounts[sum]++;
                else sumsCounts[sum] = 1;

            } 
            return count;

        }

    }
}

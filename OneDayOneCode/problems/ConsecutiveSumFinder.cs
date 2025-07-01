using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneDayOneCode.problems
{
    internal class ConsecutiveSumFinder
    {
       public static int FindCountConsecutiveSequencesRec(int[] array,  int startIndex, int endIndex,int number)
        {
            if(endIndex>=array.Length || endIndex>=array.Length) return 0;
            if (number - array[endIndex] == 0)
                return 1 + FindCountConsecutiveSequencesRec(array, startIndex, endIndex + 1, number + array[endIndex]);
             return Math.Max(FindCountConsecutiveSequencesRec(array, startIndex, endIndex + 1, number + array[endIndex])
                 ,FindCountConsecutiveSequencesRec(array, startIndex + 1, endIndex, number + array[endIndex] - array[startIndex]));
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

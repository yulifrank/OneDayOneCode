using OneDayOneCode.problems;
using OneDayOneCode.problems.tests;
using OneDayOneCode.tests;

internal class Program
{
    static int Divide(int a, int b)
    { if(b == 0) return 0;  
        int count = 0;
        while (a >= b)
        {
            count++;
            a = a - b;
        }
        return count;   
    }


    public static int MostFrequentNumber(int[] nums)
    {
        var counts = new Dictionary<int, int>();

        foreach (var num in nums)
        {
            if (counts.ContainsKey(num))
                counts[num]++;
            else
                counts[num] = 1;
        }

        int maxCount = 0;
        int mostFrequent = nums[0];

        foreach (var pair in counts)
        {
            if (pair.Value > maxCount)
            {
                maxCount = pair.Value;
                mostFrequent = pair.Key;
            }
        }

        return mostFrequent;
    }

    static void Main(string[] args)
    {
      //  LongestIncreasingSubsequenceTests.RunTests();
      //  ConsecutiveSumFinderTests.RunTests();

        LongestValidParenthesesTests.RunTests();
        Console.WriteLine(Divide(14,2));
        

    }
}

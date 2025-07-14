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
    static void Main(string[] args)
    {
      //  LongestIncreasingSubsequenceTests.RunTests();
      //  ConsecutiveSumFinderTests.RunTests();

        LongestValidParenthesesTests.RunTests();
        Console.WriteLine(Divide(14,2));
        

    }
}

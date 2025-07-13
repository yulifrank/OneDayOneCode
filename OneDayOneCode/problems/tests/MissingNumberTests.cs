using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneDayOneCode.problems.tests
{
    public class MissingNumberTests
    {
        public static void RunTests()
        {
            var solver = new MissingNumberSolver();

            RunTest(solver, new int[] { 3, 0, 1 }, 2);
            RunTest(solver, new int[] { 0, 1 }, 2);
            RunTest(solver, new int[] { 9, 6, 4, 2, 3, 5, 7, 0, 1 }, 8);
            RunTest(solver, new int[] { 0 }, 1);
            RunTest(solver, new int[] { 1 }, 0);
        }

        private static void RunTest(MissingNumberSolver solver, int[] input, int expected)
        {
            int result = solver.FindMissingNumber(input);
            string status = result == expected ? "✅ Pass" : $"❌ Fail (Expected {expected}, Got {result})";
            Console.WriteLine($"Test: [{string.Join(",", input)}] => {result} | {status}");
        }
    }
}
    
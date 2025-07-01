using System;
using OneDayOneCode.problems;

namespace OneDayOneCode.tests
{
    internal class ConsecutiveSumFinderTests
    {
        public static void RunTests()
        {
            var testCases = new (int[] array, int target, int expected)[]
            {
                (new int[] {1, 2, 3}, 3, 2),
                (new int[] {1, 1, 1}, 2, 2),
                (new int[] {1, 2, 1, 2, 1}, 3, 4),
                (new int[] {0, 0, 0}, 0, 6),
                (new int[] {1, -1, 1}, 1, 3),
                (new int[] {1, 2, 3, 4}, 6, 1),
                (new int[] {3, 4, 7, 2, -3, 1, 4, 2}, 7, 4),
                (new int[] {1}, 1, 1),
                (new int[] {5}, 5, 1),
                (new int[] {5}, 10, 0),
                (new int[] {1, 2, 1, 2, 1}, 2, 2),
                (new int[] {1, 2, 3, 4, 5}, 9, 2),
                (new int[] {10, 2, -2, -20, 10}, -10, 3),
                (new int[] {-1, -1, 1}, 0, 1),
                (new int[] {1, 2, 3, -3, -2, -1, 1, 2}, 3, 5),
                (new int[] {2, 4, 6, 8, 10}, 14, 1),
                (new int[] {1, 1, 1, 1, 1}, 3, 3),
                (new int[] {1, -1, 0}, 0, 3),
                (new int[] {1, 2, 1, 2}, 6, 1),
                (new int[] {100, -50, 50, 0}, 100, 3)
            };

            int testNum = 1;
            foreach (var (array, target, expected) in testCases)
            {
                int result = ConsecutiveSumFinder.FindCountConsecutiveSequences(array, target);
                Console.WriteLine($"Test #{testNum++}: Target = {target}, Expected = {expected}, Got = {result} => {(result == expected ? "PASS" : "FAIL")}");
                result = ConsecutiveSumFinder.FindCountConsecutiveSequencesRec(array,0,0, target);
                Console.WriteLine($"rec Test #{testNum++}: Target = {target}, Expected = {expected}, Got = {result} => {(result == expected ? "PASS" : "FAIL")}");


            }
        }
    }
}

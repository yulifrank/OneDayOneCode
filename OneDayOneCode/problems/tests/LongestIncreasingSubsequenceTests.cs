using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneDayOneCode.problems.tests
{
    internal class LongestIncreasingSubsequenceTests
    {
        public static void RunTests()
        {
            int[][] testCases = new int[][]
          {
    new int[] {2,4,8,3,6,2,5,3,8,4},
    new int[] {10,9,2,5,3,7,101,18},
    new int[] {1,2,3,4,5},
    new int[] {5,4,3,2,1},
    new int[] {1,3,2,4,3,5},
    new int[] {1},
    new int[] {},
    new int[] {7,7,7,7},
    new int[] {10,20,10,30,20,50},
    new int[] {3,1,4,1,5,9,2,6,5,3,5},
    new int[] {2,2,2,2,2,2,2},

    // 10 נוספים:
    new int[] {1, 100, 2, 99, 3, 98, 4, 97},             // רצף עולה עם ירידה חוזרת
    new int[] {5, 1, 6, 2, 7, 3, 8, 4},                  // רצף מעורב
    new int[] {1, 3, 5, 4, 7},                           // רצף עם קפיצה אחורה
    new int[] {9, 8, 7, 6, 5, 4, 3, 2, 1},               // רצף יורד מוחלט
    new int[] {1, 2, 2, 2, 3, 4, 4, 5},                   // רצף עולה עם חזרות
    new int[] {10, 5, 8, 3, 9, 4, 12, 11},                // מקרה מעורב
    new int[] {1, 2, 3, 4, 0, 5, 6},                      // רצף עולה עם קפיצה לאחור ותחילת רצף חדש
    new int[] {4, 10, 4, 3, 8, 9},                        // רצף קצר מעורב
    new int[] {2, 5, 3, 7, 11, 8, 10, 13, 6},             // רצף עולה עם הפרעות
    new int[] {1, 2, 3, 2, 3, 4, 5, 6}                     // רצף עם סירוגין בין ירידה לעלייה
          };


            Console.WriteLine("Running LIS tests:\n");
            for (int i = 0; i < testCases.Length; i++)
            {
                var arr = testCases[i];
                int recResult = LongestIncreasingSubsequence.FindLISLengthRec(arr, arr.Length - 1, int.MaxValue);
                int dpResult = LongestIncreasingSubsequence.FindLISLength(arr);

                Console.WriteLine($"Test case {i + 1}: [{string.Join(", ", arr)}]");
                Console.WriteLine($"  Recursive result: {recResult}");
                Console.WriteLine($"  DP result:        {dpResult}");
                Console.WriteLine();
            }
        }
    }
    }

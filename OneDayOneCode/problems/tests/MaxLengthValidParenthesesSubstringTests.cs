using System;
using OneDayOneCode.problems;

namespace OneDayOneCode.problems.tests
{
    public class LongestValidParenthesesTests
    {
        public static void RunTests()
        {
            // מחרוזות לבדיקה
            string[] testCases = new string[]
            {
                "",                     // מחרוזת ריקה
                "abcdef",               // ללא סוגריים בכלל
                "()()()",               // כל הסוגריים מאוזנים
                "((()",                 // עודף סוגריים פתוחים
                "())())",               // עודף סוגריים סגורים
                "(a)())()((b)",         // תווים רגילים בתערובת
                "((()())())",           // סוגריים מקוננות
                ")(())(",               // מתחיל בסוגר־סגירה
                "(()((())",             // תערובת מורכבת
                "()(())(()())"          // שני מקטעים תקינים רצופים
            };

            // הערכים הצפויים לכל מקרה
            int[] expectedResults = new int[]
            {
                0,  // ""
                0,  // "abcdef"
                6,  // "()()()"
                2,  // "((()"   -> "()"
                4,  // "())())" -> "()()"
                10,  // "(a)())()((b)" -> "(a)()"
                10, // "((()())())"
                4,  // ")(())(" -> "(())"
                6,  // "(()((())" -> "(())"
                10  // "()(())(()())"
            };

            Console.WriteLine("Running LongestValidParentheses tests:\n");
            for (int i = 0; i < testCases.Length; i++)
            {
                string s = testCases[i];
                int expected = expectedResults[i];
               // int actual = MaxLengthValidParenthesesSubstring.LongestValidParentheses(s);

                Console.WriteLine($"Test #{i + 1}: \"{s}\"");
                Console.WriteLine($"  Expected: {expected}");
                //Console.WriteLine($"  Actual:   {actual}");
                Console.WriteLine();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneDayOneCode.problems
{
    public class MaxLengthValidParenthesesSubstring
    {
        /// <summary>
        /// מחזיר את האורך של תת‑המחרוזת התקינה הארוכה ביותר בתוך s.
        /// </summary>
      public  static int LongestValidParentheses(string s)
        {
            int startIndex =s.IndexOf('(');
            int countOpen = 0;
            int countClose = 0;
            for (int i = startIndex; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    countOpen++;
                }
                if (s[i] == ')') {
                    countClose++;
                    if (countOpen - countClose >= 0)
                    {
                        countClose--;
                        countOpen--;
                    }
                }
          
            }
            return s.Length - countOpen -countClose - startIndex;
        }

    }
  
}

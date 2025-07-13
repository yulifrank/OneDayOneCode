using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneDayOneCode.problems
{
    internal class MissingNumberSolver
    {
        public int FirstUniqChar(string s)
        {
            // שלב 1: סופרים כמה פעמים כל תו מופיע
            Dictionary<char, int> counts = new Dictionary<char, int>();
            foreach (char c in s)
            {
                if (counts.ContainsKey(c))
                    counts[c]++;
                else
                    counts[c] = 1;
            }

            // שלב 2: מחפשים את האינדקס של התו הראשון שמופיע פעם אחת בלבד
            for (int i = 0; i < s.Length; i++)
            {
                if (counts[s[i]] == 1)
                    return i;
            }

            // אם אין תו כזה – נחזיר -1
            return -1;
        }
    }
}
}

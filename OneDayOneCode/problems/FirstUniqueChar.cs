using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneDayOneCode.problems
{
    internal class FirstUniqueChar
    {

        public static char FindFirstUniqueChar(string input)
        {
            Dictionary<char, int> counts = new Dictionary<char, int>();
            foreach (char c in input)
            {
                if (counts.ContainsKey(c))
                    counts[c]++;
                else
                {
                    counts[c] = 1;
                }
            }
            foreach(var  o in counts)
            {
                if(o.Value==1)
                    return o.Key;
            }
            return '0';

        }
    }
}

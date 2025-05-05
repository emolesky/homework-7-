using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Difference
{
    public class Solution
    {
        public static char FindTheDifference(string s, string t)
        {
            char result = '\0';
            foreach(char c in s)
            {
                result ^= c; 
            }
            foreach(char c in t)
            {
                result ^= c;
            }
            return result;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOfSegments
{
    public class Solution
    {
        public int CountSegments(string s)
        {
            if(string.IsNullOrWhiteSpace(s))
                return 0;


            string[] segments = s.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            return segments.Length;
        }
    }
}

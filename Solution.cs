  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ballons
{
    public class Solution
    {
        public int MaxNumberOfBaloons(string text)
        {
            int bCount = 0;
            int aCount = 0;
            int lCount = 0;
            int oCount = 0;
            int nCount = 0;

            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];

                if (c == 'b') bCount++;
                else if (c == 'a') aCount++;
                else if (c == 'l') lCount++;
                else if (c == 'o') oCount++;
                else if (c == 'n') nCount++;
            }

            lCount /= 2;
            oCount /= 2;

            int balloon = bCount;
            if (aCount < balloon) balloon = aCount;
            if (lCount < balloon) balloon = lCount;
            if (oCount < balloon) balloon = oCount;
            if (nCount < balloon) balloon = nCount;

            return balloon;


        }
    }
}

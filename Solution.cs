using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    public class Solution
    {
        public bool JudgeCircle(string moves)
        {
            int x = 0;
            int y = 0;

            foreach( char move in moves)
            {
                switch( move)
                {
                    case 'R':
                        x++;
                        break;
                    case 'L':
                        x--;
                        break;
                    case 'U':
                        y++;
                        break;
                    case 'D':
                        y--;
                        break;


                }
            }
            return x == 0 && y == 0;   
        }
    }
}

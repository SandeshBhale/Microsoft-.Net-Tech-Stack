using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Extension_Method_Assignment_1
{
    public static class CalcSpace
    {
        public static int Calc(this string space)
        {
            int cnt = 0;
            for(int i= 0; i < space.Length; i++)
            {
                if (space[i] == ' ')
                    cnt++;
            }
            return cnt;
        }
    }
}

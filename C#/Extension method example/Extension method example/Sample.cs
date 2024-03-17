using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Extension_method_example
{
    public static class Sample
    {
        public static int Countcap(this string cap)
        {
            int cnt = 0;
            for(int i = 0; i < cap.Length; i++)
            {
                if (cap[i]>='A' && cap[i]<='Z')
                    cnt++;
            }
            return cnt;
        }
    }
}

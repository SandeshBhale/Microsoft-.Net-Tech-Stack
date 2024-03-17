using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_method_Assignment_2
{
    public static class Sample
    {
        public static string Changeline(this string str)
        {
            //convert input string to character array
            char[] chars = str.ToCharArray();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 'A' && str[i] <= 'Z')
                    chars[i] = (char)(chars[i] + 32); 
            }
            return new string(chars);
        }
    }
}

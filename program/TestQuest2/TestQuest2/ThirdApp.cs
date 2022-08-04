using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestQuest2
{
    public static class ThirdApp
    {
        public static bool Chek_Palindrome(string text)
        {
            char[] reversText = text.ToCharArray();
            Array.Reverse(reversText);
            return Equals(new string(reversText).ToLower(), text.ToLower());
        }
    }
}

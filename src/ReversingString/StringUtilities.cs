using System;
using System.Linq;

namespace CodingChallenge.ReversingString
{
    public class StringUtilities
    {
        public static string Reverse(string s)
        {
             return new string(s.ToCharArray().Reverse().ToArray());
        }
    }
}

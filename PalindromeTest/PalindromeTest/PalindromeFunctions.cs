using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PalindromeTest
{
    public class PalindromeFunctions
    {
        public static    bool isPalindromeWithRegex(string input)
        {
            bool result = false;
            try
            {

                input.ToLower();
                bool isPalindrome =  input == new string(input.Reverse().ToArray());

                result = true;
            }

            catch
            {



            }
            return result;

        }

        public static bool IsPalindromeWithRegex(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                throw new ArgumentException("String is null or empty");
            }

            if (s.Length < 2)
            {
                return true;
            }

            var regex = new Regex(@"^(?'letter'[a-z0-9])+[a-z0-9]?(?:\k'letter'(?'-letter'))+(?(letter)(?!))$");
            return regex.Match(s).Success;
        }








    }
}

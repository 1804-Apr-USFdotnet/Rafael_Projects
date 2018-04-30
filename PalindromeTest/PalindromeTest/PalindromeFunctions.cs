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
        public static    bool isPalindrome(string input)
        {
            input.ToLower();
            bool result = true;
            try
            {
                int i = 0;
                int j = input.Length - 1;

                while (i < j)
                {
                    if (input[i] != input[j])
                       result =  false;

                    i++;
                    j--;
                }

 
                //bool isPalindrome =  input == new string(input.Reverse().ToArray());

            }

            catch
            {



            }
            return result;

        }

        public static bool IsPalindromeWithRegex(string s)
        {
            s.ToLower();
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

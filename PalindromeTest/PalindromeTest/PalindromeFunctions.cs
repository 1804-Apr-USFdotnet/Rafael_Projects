using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeTest
{
    public class PalindromeFunctions
    {
        public static    bool isPalindrome(string input)
        {
            bool result = false;
            try
            {
                bool isPalindrome =  input == new string(input.Reverse().ToArray());

                result = true;
            }

            catch
            {



            }
            return result;

        }






    }
}

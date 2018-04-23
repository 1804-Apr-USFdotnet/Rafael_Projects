using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PalindromeTest;

namespace PalindromeTest_tst
{
    [TestClass]
    public class isPalindromeWithRegex
    {
        [TestMethod]
        public void TestMethod1()
        {

            {
                bool expected1 = true;
                bool expected2 = true;

                bool expected3 = false;


                bool actual1 = PalindromeFunctions.isPalindromeWithRegex("racecar");
                bool actual2 = PalindromeFunctions.isPalindromeWithRegex("Never odd or even");


                bool actual3 = PalindromeFunctions.isPalindromeWithRegex("Not a palindrome");


                Assert.AreEqual(expected1, actual1);

                Assert.AreEqual(expected2, actual2);

                Assert.AreEqual(expected3, actual3);

            }
        }
    }

}

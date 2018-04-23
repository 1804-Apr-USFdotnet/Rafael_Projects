﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PalindromeTest;

namespace PalindromeTest_tst
{
    [TestClass]
    public class IsPalindrome
    {
        [TestMethod]      
        public void TestPalindromeMethod()
        {
            bool expected1 = true;
            bool expected2 = true;
            bool expected3 = false;
            bool expected4 = false;

            bool actual1 = PalindromeFunctions.isPalindromeWithRegex("racecar");
        
            bool actual2 = PalindromeFunctions.isPalindromeWithRegex("race");


            Assert.AreEqual(expected1, actual1);
       
            Assert.AreEqual(expected3, actual2);
            
        }
    }
    }
}
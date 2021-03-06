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
            bool expected2 = false;


            bool actual1 = PalindromeFunctions.isPalindrome("racecar");
        
            bool actual2 = PalindromeFunctions.isPalindrome("race");


            Assert.AreEqual(expected1, actual1);
       
            Assert.AreEqual(expected2, actual2);
            
        }
    }
    }

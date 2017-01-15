
/*  •	"anna" will return true.
•	"aaaaaaaa" will return true.
•	"aaaaaaaab" will return true.
•	"caaaaaaaab" will return false.
•	"donotbobtonod" will return true.
•	"owefhijpfwai" will return false.
•	"igdedgide" will return true.
*/

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestPalindrome
{
    [TestClass]
    public class TestPalindrome
    {
        [TestMethod]
        public void ResultsTrueWhenAllCharsAreEqual()
        {
            string result;
            Assert.IsTrue(PalindromeModel.Palindrome.IsPalindromeAnagramorNeither("aaaaaaaa", out result));

        }

        [TestMethod]
        public void ResultsTrueWhenOneCharIsdifferent()
        {
            string result;
            Assert.IsTrue(PalindromeModel.Palindrome.IsPalindromeAnagramorNeither("aaaaaaaab", out result));
        }

        [TestMethod]
        public void ResultsFalseWhenFirstandLastCharIsdifferent()
        {
            string result;
            Assert.IsFalse (PalindromeModel.Palindrome.IsPalindromeAnagramorNeither("caaaaaaaab", out result));
        }


        [TestMethod]
        public void ResultsTrueWhenStringisPalindrome()
        {
            string result;
            Assert.IsTrue(PalindromeModel.Palindrome.IsPalindromeAnagramorNeither("donotbobtonod", out result));
        }

        [TestMethod]
        public void ResultsFalseWhenStringisNotAPalindromeorAnagram()
        {
            string result;
            Assert.IsFalse(PalindromeModel.Palindrome.IsPalindromeAnagramorNeither("owefhijpfwai", out result));
        }
        [TestMethod]
        public void ResultsTrueWhenStringisNotAPalindromeButAnagram()
        {
            string result;
            Assert.IsTrue(PalindromeModel.Palindrome.IsPalindromeAnagramorNeither("igdedgide", out result));
        }
       
    }
}

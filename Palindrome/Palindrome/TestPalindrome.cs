using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sys

namespace Palindrome
{
 
    [TestClass]
    public class TestPalindrome
    {
        [TestMethod]
        public void ResultsNegativeWhenAtleastOneStringIsEmpty()
        {
            int result = 99;
            Assert.IsFalse(SampleHelpers.IsAnagram("brother", "", out result));
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void ResultsOneWhenStringLenghtsAreNotEqual()
        {
            int result = 99;
            Assert.IsFalse(SampleHelpers.IsAnagram("brother", "broth", out result));
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void ResultsZeroWhenStringsAreEqual()
        {
            int result = 99;
            Assert.IsTrue(SampleHelpers.IsAnagram("brother", "brother", out result));
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void ResultsTwoWhenStringsAreNotAnagrams()
        {
            int result = 99;
            Assert.IsFalse(SampleHelpers.IsAnagram("brother", "brothes", out result));
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void ResultsTwoWhenStringsAreAnagrams()
        {
            int result = 99;
            Assert.IsTrue(SampleHelpers.IsAnagram("brother", "borthre", out result));
            Assert.AreEqual(2, result);
        }
    }
}

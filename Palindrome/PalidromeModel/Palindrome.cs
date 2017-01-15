using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeModel
{
    public static class Palindrome
    {

        public static bool IsPalindromeAnagramorNeither(string input, out string result)
        {

            //palindrome checking
            if (PalindromeModel.Palindrome.IsPalindrome(input))
            {
                result = "a palindrome";
                return true;
            }

            //if not a palindrome check for anagram
            else if (PalindromeModel.Palindrome.IsPalindromeAnagram(input)) //(IsAnagram(s,revs , out res ))//
            {

                result = "an anagram of a palindrome";
                return true;

            }
            else
            {
                //both failed
                result = "Neither";
                return false;

            }
        }

        /// <summary>
        /// Check for palindrome for given string
        /// </summary>
        private static bool IsPalindrome(string input)
        {
            string reversed = Reversed(input);
            return input == reversed;
        }

        /// <summary>
        /// Check for anagram for a given palindrome
        /// </summary>
        private static bool IsPalindromeAnagram(string input)
        {
            //reverse string to check anagram
            string reversed = Reversed(input);

            //anagram check - grouping and counting distinct characters of the string
            var charCount = reversed.GroupBy(c => c, (c, i) => new
            {
                character = c,
                count = i.Count() //returns no of elements in the sequence
            });

            //check for distinct characters odd count and returns true if only one odd count character is available
            return charCount.Count(c => c.count % 2 == 1) <= 1;
        }

        
        public static string Reversed(string input)
        {
            return new string(input.ToCharArray().Reverse().ToArray());
        }

        /*
        Another simple approach to check anagram is sorting charcters of both words and compare strings
        Not used

        private static st
        ring Sort(string input)
        {
            var chars = input.ToCharArray();
            Array.Sort(chars);
            return new string(chars);
        }

        private static bool AnagrambySort(string input, string reversed)
        {

            return Sort(input) == Sort(reversed);
        }
        */
    }
}













    


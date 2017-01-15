using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PalindromeModel;

namespace PalindromeConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;

            do
            {
                Console.WriteLine("Enter word to check palindrome or anagram or neither");

                //read input
                input = Console.ReadLine();

                string result;

                //check palidrome or anagram returns string result
                bool ispalindrome = PalindromeModel.Palindrome.IsPalindromeAnagramorNeither(input, out result);

                //pirnt result
                Console.WriteLine(result);

                Console.Write("Do You Want To Continue Check Palindrome? (Y/N) ");
            } while ((Console.ReadLine().ToUpper() == "Y"));
           // Console.ReadKey();
        }

    }
}

    



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeChecker
{
    public class ChecksPalindromes
    {

        public string isThisAPalindrome(string input)
        {
             
            char[] inputArr = input.ToLower().ToCharArray();
             Array.Reverse(inputArr);
            
            return new string (inputArr);




        }
    }
}
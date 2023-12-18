using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountVowels
{
    public class VowelCount
    {
        public int countVowels(string input)
        {
            int count = 0;
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            if (!string.IsNullOrEmpty(input))
            {
                var lowerCase = input.ToLower();

                //int count = 0;
                foreach (char c in lowerCase)
                {
                    if (Array.IndexOf(vowels, c) >= 0)
                    {
                        count++;
                    }
                }

                return count;
            }
            else {
                Console.WriteLine("String is Empty");
                return 0; }
        }
    

    }
           


}


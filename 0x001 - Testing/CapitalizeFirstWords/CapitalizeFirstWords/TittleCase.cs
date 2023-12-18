using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapitalizeFirstWords
{
    //take the string input from user
    //split the input into an array of words, at any incidence of a space 
    //set every word[i][0] toUpper, that will capitalise each first letter of every word
    //rejoin the words
    public  class TittleCase
    {
        public void tittleCase(string input) 
        {
            string[] words = input.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                if (!string.IsNullOrEmpty(words[i])) 
                {
                    var capitalizedLetter = char.ToUpper(words[i][0]);
                   string finalString = string.Join(" ", $"{capitalizedLetter+words[i][1..]} ");

                    
                    Console.Write($"{finalString}");
                    
                }

            
            }




        }
    }
}

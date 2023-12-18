using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ReverseInteger
{
    public class IntInReverseOrder
    {
       public  int reverseNumber(string value) 
        {
           bool isNumber = int.TryParse(value, out int number);
            if (isNumber)
            {
                   bool isNegative = value.Contains("-");  
                   char[] numbersArray= value.ToCharArray();
                   Array.Reverse(numbersArray);
                   string reversedValue = new string (numbersArray).TrimStart('0').TrimEnd('-');
                   return isNegative ? Convert.ToInt32($"-{reversedValue}") : Convert.ToInt32(reversedValue);
            }
            throw new Exception($"Dont try to be funny {value} cannot be parsed into an integer");
        }
    }
}

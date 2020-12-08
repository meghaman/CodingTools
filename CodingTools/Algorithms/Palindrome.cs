using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTools.Algorithms
{
    public class Palindrome
    {
        public bool IsPalindrome(int? number)
        {
            if (number == null)
                return true;

            string strNumber = number.ToString();
            int numberOfDigits = strNumber.Length;
            Console.WriteLine("Number Of Digits: " + numberOfDigits);

            Console.WriteLine("Are even number of digits: " + (numberOfDigits % 2 == 0));

            string firstHalf = strNumber.Substring(0, numberOfDigits / 2);
            string secondHalf;

            if (numberOfDigits % 2 == 0)
                secondHalf = strNumber.Substring(numberOfDigits / 2);
            else
                secondHalf = strNumber.Substring(((numberOfDigits - 1) / 2) + 1);

            for (int i = 0; i < firstHalf.Length; i++)
            {
                Console.WriteLine("Comparing: " + firstHalf[(firstHalf.Length - 1) - i] + " with " + secondHalf[i]);
                if (firstHalf[(firstHalf.Length - 1) - i] != secondHalf[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}

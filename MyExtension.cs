using System;
using System.Collections.Generic;

namespace Extension
{
    public static class MyExtension
    {
        /// <summary>
        /// Mehod that return sum of  'n' digit
        /// </summary>        
        /// <param name="n">Element parameter</param>
        /// <returns>Integer value</returns>
        public static int SummaDigit(this int n)
        {
            int sum = 0;
            while (n != 0)
            {
                sum += n % 10;
                n /= 10;
            }
            return Math.Abs(sum);
        }

        /// <summary>
        /// Method that return sum of 'n' element and reverse of 'n'
        /// </summary>
        /// <param name="n">Element parameter</param>
        /// <returns>Ulong value</returns>
        public static ulong SummaWithReverse(this uint n)
        {
            uint sum = n;
            uint revNumber = 0;
            while ( n != 0)
            {
                revNumber *= 10;
                revNumber += (n % 10);
                n /= 10;
            }
            sum += revNumber;
            return sum;
        }
       
        /// <summary>
        /// Method that count amount of elements in string , which are not letters of the latin alphabet.
        /// </summary>
        /// <param name="str">String parameter</param>
        /// <returns>Integer value</returns>
        public static int CountNotLetter(this string str)
        {
            
            int count = 0;
            foreach (char c in str)
            {
                char lowerChar = Char.ToLower(c);
                if (!(lowerChar >= 'a' && lowerChar <= 'z'))
                {
                    count++;
                }
            }
            return count;
        }

      
        /// <summary>
        /// Method that checks whether day is weekend or not 
        /// </summary>
        /// <param name="day">DayOfWeek parameter</param>
        /// <returns>Bool value</returns>
        public static bool IsDayOff(this DayOfWeek day)
        {
            return day == DayOfWeek.Sunday || day == DayOfWeek.Saturday;
        }

       
        /// <summary>
        /// Method that return positive ,even  element from collection 
        /// </summary>
        /// <param name="numbers">Collection of elements</param>
        /// <returns>IEnumerable -int collection  </returns>
        public static IEnumerable<int> EvenPositiveElements(this IEnumerable<int> numbers)
        {
            List<int> list = new List<int>();
            foreach (  int number in numbers )
            {
                if (number > 0 && number % 2 == 0)
                     
                {
                  list.Add(number);
                }
            }
            return list;
        }
    }
    
}

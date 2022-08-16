using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOeverloadExercise
{
    internal class Methods
    {

        public static int Add(int x, int y)
        {
            return x + y;
        }
        
        public static decimal Add(decimal x, decimal y)
        {
            return x + y;
        }

        public static string Add(int x, int y, bool isItDollars)
        {
            var sum = x + y; 

            if (isItDollars == true && sum > 0)
            {
                return $"{sum} Dollars";
            }
            else if (isItDollars == true && sum == 1)
            {
                return $"{sum} Dollar";
            }
            else if (isItDollars == true && sum < 0)
            {
                return $"{sum} Dollars";
            }
            else
            {
                return sum.ToString();
            }
        }
        public static string ADD(decimal x, decimal y, bool isItDollars)
        {
            var sum = x + y;

            if (isItDollars == true && sum > 0)
            {
                return $"{sum} Dollars";
            }
            else if (isItDollars == true && sum == 1)
            {
                return $"{sum} Dollar";
            }
            else if (isItDollars == true && sum < 0)
            {
                return $"{sum} Dollars";
            }
            else
            {
                return sum.ToString();
            }

        }



    }
}

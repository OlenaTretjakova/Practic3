using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic3
{
    internal class Task2
    {

        public static bool IsPrime(int num)
        {
            if (num == 1 || num == 2 || num == 3)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

    }
}

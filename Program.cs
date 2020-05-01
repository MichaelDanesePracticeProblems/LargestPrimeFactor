using System;
using System.Collections.Generic;

namespace LargestPrimeFactor
{
    /*
    The prime factors of 13195 are 5, 7, 13 and 29.

    What is the largest prime factor of the number 600851475143 ?
    */
    class Program
    {
        static void Main(string[] args)
        {
            List<int> primeNumbers = new List<int>();

            long ceiling = 600851475143;
            int max = Convert.ToInt32(Math.Floor(Math.Sqrt(ceiling)));
            long half;
            bool divisible = false;
            for (int i = 3; i < max; i += 2)
            {
                divisible = false;
                for (int j = 0; j < primeNumbers.Count; j++)
                {
                    if (i % primeNumbers[j] == 0)
                    {
                        divisible = true;
                        break;
                    }
                }
                if (!divisible)
                {
                    primeNumbers.Add(i);
                }
            }
            int largest = 0;
            for (int i = (primeNumbers.Count - 1); i > -1 ;i--)
            {
                if (ceiling % primeNumbers[i] == 0)
                {
                    largest = primeNumbers[i];
                    break;
                }
            }
            Console.WriteLine();
            Console.WriteLine(largest);
        }
    }

}


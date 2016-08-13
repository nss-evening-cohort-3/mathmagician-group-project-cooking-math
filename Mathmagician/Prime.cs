using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class Prime : Integer
    {
        public Prime(int number) : base(number)
        {
            this.primeList = new List<int>();
        }

        public List<int> primeList { get; set; }

        // Takes a number and checks to see if it is prime
        public static bool isPrime(int number)
        {
            int boundary = (int)Math.Floor(Math.Sqrt(number));

            if (number == 0) return false;
            if (number == 1) return false;
            if (number == 2) return true;

            for (int i = 2; i <= boundary; ++i)
            {
                if (number % i == 0) return false;
            }

            return true;
        }

        public override List<int> MakeListOfIntegers(int numOfIntegersToWrite)
        {

            for (int i = 1; primeList.Count != numOfIntegersToWrite; i++)
            {

                if (isPrime(i))
                {
                    primeList.Add(i);
                }

            }
            return primeList;
        }
           
    }

}

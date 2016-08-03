using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    class Fibonacci
    {
        public List<int> Make_Fibonacci(int numbersToAdd)
        {
            int x = numbersToAdd;
            int a = 0;
            int b = 1;
            List<int> FibList = new List<int>();
            for (int i = 0; i <= x; i++)
            {
                int c = a + b;
                FibList.Add(a + b);
                a = b;
                b = c;
            }
            return FibList;
        }
        public void writeFibNumbersToConsole(List<int> NumberofFibsToWrite)
        {
            foreach (var integer in NumberofFibsToWrite)
            {
                Console.WriteLine(integer);
            }
        }
    }
}

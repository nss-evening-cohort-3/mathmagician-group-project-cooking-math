using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class Fibonacci : IMakeIntegerList
    {
        public List<int> MakeListOfIntegers(int numbersToAdd)
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

        public void WriteNumberListToConsole(List<int> integers)
        {
            throw new NotImplementedException();
        }
    }
}

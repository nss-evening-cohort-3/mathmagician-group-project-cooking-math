using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class Fibonacci : Integer
    {
        public Fibonacci(int number) : base(number)
        {
            this.fibList = new List<int>();
        }

        public List<int> fibList { get; set; }

        public override List<int> MakeListOfIntegers(int numOfIntegersToWrite)
        {
            fibList.Insert(0, 1);
            int a = 0;
            int b = 1;
            for (int i = 0; fibList.Count != numOfIntegersToWrite; i++)
            {
                int c = a + b;
                fibList.Add(a + b);
                a = b;
                b = c;
            }

            return fibList;
        }
    }
}

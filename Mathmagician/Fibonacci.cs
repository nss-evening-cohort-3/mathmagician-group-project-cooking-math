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
        { }

        public override List<int> MakeListOfIntegers(int number)
        {
            //intList.Insert()
            int x = number - 2;
            int a = 0;
            int b = 1;
            for (int i = 0; i < x; i++)
            {
                int c = a + b;
                intList.Add(a + b);
                a = b;
                b = c;
            }
            intList.Insert(0, 0);
            intList.Insert(1, 1);
            return intList;
        }
    }
}

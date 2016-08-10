using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class Odd : Integer
    {
        public Odd(int number) : base(number)
        { }
        
        public override List<int> MakeListOfIntegers(int number)
        {
            for (int i = 1; i < number * 2; i++)
            {
                if (!(i % 2 == 0))
                {
                    intList.Add(i);
                }
                else continue;
            }
            return intList;
        }
    }
}
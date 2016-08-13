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
        {
            this.oddList = new List<int>();
        }

        public List<int> oddList { get; set; }

        public override List<int> MakeListOfIntegers(int number)
        {
            for (int i = 1; i < number * 2; i++)
            {
                if (!(i % 2 == 0))
                {
                    oddList.Add(i);
                }
                else continue;
            }
            return oddList;
        }
    }
}
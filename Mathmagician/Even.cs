using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class Even : Integer
    {

        public Even(int number) : base(number)
        {
        }


        public override List<int> MakeListOfIntegers(int num)
        {

            for (int i = 1; intList.Count != num; i++)
            {
                if (i % 2 == 0)
                {
                    intList.Add(i);
                }
            }
            return intList;
        }



    }
}

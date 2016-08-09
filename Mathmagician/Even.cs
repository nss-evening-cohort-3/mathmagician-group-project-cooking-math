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
            integer = number;
            evensList = new List<int>();
        }

        // intList will be set through MakeListofIntegers
        public List<int> evensList { get; set; }


        public override List<int> MakeListOfIntegers(int num)
        {

            for (int i = 1; evensList.Count != num; i++)
            {
                if (i % 2 == 0)
                {
                    evensList.Add(i);
                }
            }
            return evensList;
        }



    }
}

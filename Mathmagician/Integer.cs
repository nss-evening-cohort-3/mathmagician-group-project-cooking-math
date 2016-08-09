using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class Integer : IMakeIntegerList
    {
        public Integer(int number)
        {
            integer = number;
            intList = new List<int>();
        }

        // integer property is modified by the original integer call from Program.cs
        public int integer { get; set; }
        // intList will be set through MakeListofIntegers
        public List<int> intList { get; set; }

        public virtual List<int> MakeListOfIntegers(int numOfIntegersToWrite)
        {
            int x = numOfIntegersToWrite;

            for (int i = 1; i <= x; i++)
            {
                intList.Add(i);
            }
            return intList;
        }

        public void WriteNumberListToConsole(List<int> integers)
        {
            foreach (var integer in integers)
            {
                Console.WriteLine(integer);
            }
        }
    }
}
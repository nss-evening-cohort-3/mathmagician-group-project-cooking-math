using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class Integer : IMakeIntegerList 
    {

        public List<int> MakeListOfIntegers(int numOfIntegersToWrite)
        {
            int x = numOfIntegersToWrite;
            List<int> IntList = new List<int>();
            
            for (int i = 1; i <= x; i++)
            {
                IntList.Add(i);
            }
            return IntList;
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

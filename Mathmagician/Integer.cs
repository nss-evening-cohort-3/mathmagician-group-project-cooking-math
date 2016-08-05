using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class Integer : IMakeIntegerList
    {

        //return a list
        //integer as parameter



        public List<int> MakeListOfIntegers(int number)
        {
            int x = number;
            List<int> IntList = new List<int>();
            for (int i = 1; i < number; i++)
            {
                IntList.Add(i);
            }
            return IntList;
        }

        public void WriteNumberListToConsole(List<int> integers)
        {
            foreach (var integer in integers)
            {
                Console.WriteLine("{0}", integer);
            }
        }
    }
}
        //public List<int> MakeListOfIntegers(int numOfIntegersToWrite)
        //{
        //    int x = numOfIntegersToWrite;
        //    List<int> IntList = new List<int>();
            
        //    for (int i = 1; i <= x; i++)
        //    {
        //        IntList.Add(i);
        //    }
        //    return IntList;
        //}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class Odd : IMakeIntegerList
    {
        
        private List<int> OddNumberList = new List<int>();
        public List<int> MakeListOfIntegers(int number)
        {
            for (int i = 1  ; i < number * 2; i++)
            {
                if (!(i % 2 == 0))
                {
                    OddNumberList.Add(i);
                }
                else continue;
            }
            return OddNumberList;
        }

        public void WriteNumberListToConsole(List<int> integers)
        {
            throw new NotImplementedException();
        }
    }
}


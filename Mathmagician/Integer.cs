using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class Integer
    {
        // This code will be re-worked in a subsequent test to be more TDD appropriate.
        // Leaving it in for now just to demonstrate that the first run of the CLI is working.

        public List<int> Make_Integers(int numOfIntegersToWrite)
        {
            int x = numOfIntegersToWrite;
            List<int> IntegersToWrite = new List<int>();
            
            for (int i = 1; i <= x; i++)
            {
                IntegersToWrite.Add(i);
            }
            return IntegersToWrite;
        }

        public void WriteIntegersToConsole(List<int> IntegersToWrite)
        {
            foreach (var integer in IntegersToWrite)
            {
                Console.WriteLine(integer);
            }
        }
    }
}

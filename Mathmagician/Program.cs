using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    class Program
    {
        static void Main(string[] args)
        {
          


        }
        public static void WriteNumberListToConsole(List<int> NumList)
        {

            foreach (var integer in NumList)
            {
                Console.WriteLine(integer);
            }
                Console.ReadLine();
        }
    }
}


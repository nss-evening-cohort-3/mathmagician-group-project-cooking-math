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
            Integer my_int = new Integer();
            my_int.WriteIntegersToConsole(my_int.Make_Integers(5));
            Console.ReadLine();
            Odd my_odd = new Odd();
            my_odd.WriteOddsToConsole(my_odd.StoreOddNumbers(10));
            Console.ReadLine();
        }
    }
}

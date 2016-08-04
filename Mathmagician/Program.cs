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

            string prompt = "> ";

            Console.WriteLine("Let's cook some math!");
            Console.WriteLine("Your choices are integers, primes, evens, odds, or Fibonnaci numbers.");
            Console.WriteLine("What type of number would you like me to display?");
            Console.Write(prompt);
            
            // Take the user's input command and store it as a variable (userRequest)
            string userRequest = Console.ReadLine();
            Console.WriteLine(userRequest + System.Environment.NewLine);

            Console.WriteLine("How many numbers shall I display?");
            Console.Write(prompt);

            // Take the user's input and store it as another variable (numberToWrite)
            int numberToWrite = Int32.Parse(Console.ReadLine());

            // Logic here (probably a switch statment) that takes the stored input and uses it to call a method


            // INTEGER METHOD
            Integer my_int = new Integer();
            my_int.WriteIntegersToConsole(my_int.Make_Integers(numberToWrite));
            Console.ReadLine();

            // ODD METHOD


            // FIBONNACI METHOD


            // EVEN METHOD

            // PRIME METHOD


            // ADD THE OPTION TO GO AGAIN
        }
    }
}

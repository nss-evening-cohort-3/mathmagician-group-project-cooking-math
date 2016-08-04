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




            Console.WriteLine("LET'S COOK SOME MATH!");

            bool goAgain = true;

            while (goAgain)
            {
                Console.WriteLine("Your choices are integer, prime, even, odd, or Fibonacci numbers.");
                Console.WriteLine("What type of number would you like me to display?");
                Console.Write(prompt);

                // Take the user's input command and store it as a variable (userRequest)
                string showThisNumberType = null;

                while (showThisNumberType == null)
                {
                    string userRequest = Console.ReadLine().ToLower();

                    if (userRequest == "odd" || userRequest == "even" || userRequest == "prime" || userRequest == "integer")
                    {
                        showThisNumberType = "Yay";
                        Console.WriteLine("Okay, we'll show " + userRequest + "s." + System.Environment.NewLine);
                    }
                    else if ( userRequest == "fibonacci")
                    {
                        showThisNumberType = "Yay";
                        Console.WriteLine("Okay, we'll show Fibonacci numbers." + System.Environment.NewLine);
                    }
                    else if (userRequest == "no" || userRequest == "quit" || userRequest == "exit" || userRequest == "help" || userRequest == "nope" || userRequest == "make me")
                    {
                        Console.WriteLine(System.Environment.NewLine + "Loser.");
                        Console.ReadLine();
                        return;  // Exits the program
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid choice (check your spelling?).");
                        Console.Write(prompt);
                    }
                }

               
                Console.WriteLine("How many numbers shall I display?");
                Console.Write(prompt);

                // Take the user's input, convert it to an integer (using the TryParse method)
                // and store it as another variable (numberToWrite) that will be fed into the number methods later.

                var userNumber = Console.ReadLine();
                var numberToWrite = 0;

                // TryParse method follows
                bool result = Int32.TryParse(userNumber, out numberToWrite);
                if (result)
                {
                    Console.WriteLine("Converted '{0}' to {1}.", userNumber, numberToWrite);
                }
                else
                {
                    //            if (value == null) value = ""; 
                    Console.WriteLine("Attempted conversion of '{0}' failed. Please input a number.",
                                       userNumber == null ? "<null>" : userNumber);
                }
                Console.WriteLine("");

                //////////////////////////////////////////////////////////////////////////////////////////////////////////////
                // Logic will go here (probably a switch statment) that takes the stored input and uses it to call a method //
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////

                // INTEGER METHOD
                Integer my_int = new Integer();
                my_int.WriteIntegersToConsole(my_int.Make_Integers(numberToWrite));


                // ODD METHOD


                // FIBONNACI METHOD


                // EVEN METHOD


                // PRIME METHOD

                // Allows user to choose to quit or continue

                Console.WriteLine(System.Environment.NewLine + "Go again: Yes or No?");
                string userChoice = Console.ReadLine().ToLower();

                if (userChoice == "no")
                {
                    goAgain = false;
                    Console.WriteLine("Thanks for playing!");
                    Console.ReadLine();
                    return;
                }

                Console.WriteLine("");
            }

        }
    }
}

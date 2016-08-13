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

            while (goAgain)  // This loop allows the user to continue playing
            {
                Console.WriteLine("Your choices are integer, prime, even, odd, or Fibonacci numbers.");
                Console.WriteLine("What type of number would you like me to display?");
                Console.Write(prompt);

                // The loop below is designed to catch a user's input of an invalid response to the first prompt.

                string showThisNumberType = null;  // Only gets a value after the user inputs a valid choice (on prompt)

                while (showThisNumberType == null)  // Starts the "until the user puts in a valid choice" loop
                {
                    string userRequest = Console.ReadLine().ToLower();  // converts the user's request to lower case letters and stores it as 'userRequest'

                    if (userRequest == "odd" || userRequest == "even" || userRequest == "prime" || userRequest == "integer")
                    {
                        showThisNumberType = userRequest;  // Indicates that the user has provided a valid input (and quits the loop)
                        Console.WriteLine("Okay, we'll show " + userRequest + "s." + System.Environment.NewLine);

                    }
                    else if (userRequest == "fibonacci")
                    {
                        showThisNumberType = userRequest;  // Also indicates input of a valid choice (ending the loop)
                        Console.WriteLine("Okay, we'll show Fibonacci numbers." + System.Environment.NewLine);
                    }
                    // Options that quit the program if user can't figure out how (or refuses) to input a valid choice:
                    else if (userRequest == "no" || userRequest == "quit" || userRequest == "exit" || userRequest == "help" || userRequest == "nope" || userRequest == "make me")
                    {
                        Console.WriteLine(System.Environment.NewLine + "Loser.");
                        Console.ReadLine();
                        return;  // Exits the program
                    }
                    else   // If the user's input is invalid, the following message (and prompt) appears
                           // (This prompt will continue until one of the exit options --see 'else if' above -- or a valid choice is entered)
                    {
                        Console.WriteLine("Whoops! Please enter a valid choice (check your spelling?).");
                        Console.Write(prompt);
                    }
                }

                // Second prompt -- this time for the number of integers to display

                Console.WriteLine("How many numbers shall I display?");
                Console.Write(prompt);

                // Take the user's input, convert it to an integer (using the TryParse method)
                // and store it as another variable (numberToWrite) that will be fed into the number methods later.

                var userNumber = Console.ReadLine();
                var numberToWrite = 0;  // A temporary variable used later for storing the user's input (after it has been converted to int)

                // TryParse method follows -- attempts to convert user's input to an integer
                // If the number will not parse, an error message is returned.
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

                switch (showThisNumberType)
                {
                    case "integer":
                        // Code that calls the integer method:
                        Integer integer = new Integer(numberToWrite);
                        List<int> intList = integer.MakeListOfIntegers(numberToWrite);
                        integer.WriteNumberListToConsole(intList);
                        break;
                    case "prime":
                        // Code that calls the prime number method:
                        Prime prime = new Prime(numberToWrite);
                        List<int> primeList = prime.MakeListOfIntegers(numberToWrite);
                        prime.WriteNumberListToConsole(primeList);
                        break;
                    case "odd":
                        // Code that calls the odd number method:
                        Odd odd = new Odd(numberToWrite);
                        List<int> oddList = odd.MakeListOfIntegers(numberToWrite);
                        odd.WriteNumberListToConsole(oddList);
                        break;
                    case "even":
                        // Code that calls the even number method:
                        Even ourEvens = new Even(numberToWrite);
                        List<int> evensList = ourEvens.MakeListOfIntegers(numberToWrite);
                        ourEvens.WriteNumberListToConsole(evensList);
                        break;
                    case "fibonacci":
                        // Code that calls the Fibonacci method:
                        Fibonacci fibonacci = new Fibonacci(numberToWrite);
                        List<int> fibList = fibonacci.MakeListOfIntegers(numberToWrite);
                        fibonacci.WriteNumberListToConsole(fibList);
                        break;
                }

                // The following code allows user to choose to quit or continue

                Console.WriteLine(System.Environment.NewLine + "Go again: Yes or No?");
                string[] yesAnswers = { "yes", "y", "sure", "ya", "yeah", "ja", "yup", "yo", "let's cook some math", "ok", "okay", "fine", "why not?", "i guess", "you're not my real dad", "i am the one who knocks" };
                string userChoice = Console.ReadLine().ToLower();

                if (userChoice == "no" || userChoice == "n")  // If the user chooses to exit
                {
                    goAgain = false;
                    Console.WriteLine("Thanks for playing!");
                    Console.ReadLine();
                    return;
                }
                else if (!yesAnswers.Any(userChoice.Contains))
                {
                    goAgain = false;
                    Console.WriteLine("You typed " + userChoice + ". You do not follow instructions very well.  Good day to you!");
                    Console.ReadLine();
                    return;
                }
            }
            Console.WriteLine("");
        }
       }
}



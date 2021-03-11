using System;

namespace dotNetApp
{
    // Main Class
    class Program
    {
        //Init a player
        static string player = string.Empty; 
        
        // Entry Point Method
        public static void Main(string[] args)
        {
            GetAppInfo(); // Run GetAppInfo function to display app information

            GreetPlayer(); // Ask for user's name and greet

            while (true)
            {

                
                // Create a new Random object
                Random random = new Random();

                // Init random number
                int randomNumber = random.Next(1, 10);

                // Init guess var
                int guess = 0;

                // Ask user for number
                Console.WriteLine("Guess a number between 1 and 10");

                // While guess is not correct
                while (guess != randomNumber)
                {
                    // Get user's input
                    string input = Console.ReadLine();

                    // Make sure user enters an int
                    if (!int.TryParse(input, out guess))
                    {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Please enter an actual number");

                        // Keep going
                        continue;
                    }
                    else if (guess >= 10 || guess <= 0)
                    {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Please enter a number that is greater than 0 and less than 10");

                        // Keep going
                        continue;
                    }

                    // Cast to int and put in guess
                    guess = Int32.Parse(input);

                    // Match guess to correct number
                    if (guess != randomNumber)
                    {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again");
                    }
                }

                // Print success message
                PrintColorMessage(ConsoleColor.Yellow, "Congratulations " + player + "!! You guessed it!");

                // Ask to play again
                Console.WriteLine("Play Again? [Y or N]");

                // Get user's answer
                string answer = Console.ReadLine().ToUpper();

                
                if (answer == "Y") {
                    continue;
                }
                else if (answer == "N") {
                    Console.WriteLine("Bye for now " + player + ". Thanks for playing!");
                    return;
                }
                else
                {
                    Console.WriteLine("You entered an invalid answer so you must be tired. It seems you need a break so bye for now " + player + ". Thanks for playing!");
                    return;
                }
            }           

        }

        // Create app information
        static void GetAppInfo() {
            // Set app vars
            string appName = "Random Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Hlengiwe Ndaba";

            // Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            // Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Reset text color
            Console.ResetColor();
        }

        // Ask user's name and greet
        public static void GreetPlayer() {
            // Ask user's name
            Console.WriteLine("What is your name?");

            // Get user's input and set player's name
            player = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", player);
        
        }

        // Print color message
        static void PrintColorMessage(ConsoleColor color, string message) {
            // Change text color
            Console.ForegroundColor = color;

            // Tell user its not a number
            Console.WriteLine(message);

            // Reset text color
            Console.ResetColor();
        }
    }
}

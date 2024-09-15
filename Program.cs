
using System;
namespace CinemaMenu_;

class Program
{
    static void Main()
    {
        // This will keep the program running until the user exits
        bool isRunning = true;

        // Main menu loop
        while (isRunning)
        {
            // Display the main menu
            Console.WriteLine("\nWelcome to the Main Menu:");
            Console.WriteLine("1. Youth or Senior Price Check");
            Console.WriteLine("2. Group Cinema Pricing");
            Console.WriteLine("3. Repeat Text 10 Times");
            Console.WriteLine("4. Extract the Third Word");
            Console.WriteLine("0. Exit");
            Console.Write("Please select an option: ");

            // Get user input
            string input = Console.ReadLine();

            // Switch statement for handling the menu options
            switch (input)
            {
                case "0":
                    // Exit the program
                    Console.WriteLine("Exiting the program...");
                    isRunning = false; // Breaks the while loop
                    break;

                case "1":
                    // Case 1: Youth or Senior Price Check
                    Console.Write("Please enter your age: ");
                    if (int.TryParse(Console.ReadLine(), out int age))
                    {
                        if (age < 20)
                        {
                            Console.WriteLine("Youth price: 80kr");
                        }
                        else if (age > 64)
                        {
                            Console.WriteLine("Senior price: 90kr");
                        }
                        else
                        {
                            Console.WriteLine("Standard price: 120kr");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid age input!");
                    }
                    break;

                case "2":
                    // Case 2: Group Cinema Pricing
                    Console.Write("How many people are in your group? ");
                    if (int.TryParse(Console.ReadLine(), out int numPeople))
                    {
                        int totalCost = 0;
                        for (int i = 0; i < numPeople; i++)
                        {
                            Console.Write($"Enter age for person {i + 1}: ");
                            if (int.TryParse(Console.ReadLine(), out int personAge))
                            {
                                if (personAge < 20)
                                {
                                    totalCost += 80;
                                }
                                else if (personAge > 64)
                                {
                                    totalCost += 90;
                                }
                                else
                                {
                                    totalCost += 120;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid age input!");
                            }
                        }
                        Console.WriteLine($"Total number of people: {numPeople}");
                        Console.WriteLine($"Total cost: {totalCost}kr");
                    }
                    else
                    {
                        Console.WriteLine("Invalid number of people input!");
                    }
                    break;

                case "3":
                    // Case 3: Repeat Text 10 Times
                    Console.Write("Please enter some text: ");
                    string userInput = Console.ReadLine();
                    for (int i = 1; i <= 10; i++)
                    {
                        Console.Write($"{i}. {userInput}, ");
                    }
                    Console.WriteLine(); // Add a newline after the loop
                    break;

                case "4":
                    // Case 4: Extract the Third Word
                    Console.Write("Please enter a sentence with at least three words: ");
                    string sentence = Console.ReadLine();
                    string[] words = sentence.Split(' '); // Split sentence into words
                    if (words.Length >= 3)
                    {
                        Console.WriteLine($"The third word is: {words[2]}");
                    }
                    else
                    {
                        Console.WriteLine("The sentence doesn't contain enough words.");
                    }
                    break;

                default:
                    // Default case for invalid input
                    Console.WriteLine("Invalid selection. Please enter a valid option.");
                    break;
            }
        }
    }
}

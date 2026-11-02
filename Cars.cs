using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Creates a dictionary
        Dictionary<string, List<string>> cars =
            new Dictionary<string, List<string>>(
                StringComparer.OrdinalIgnoreCase);

        // Keeps the program running until the user chooses to exit.
        bool running = true;

        // Repeats the menu while running is true.
        while (running)
        {
            // Displays the menu options to the user.
            Console.WriteLine("\n===== CAR DICTIONARY =====");
            Console.WriteLine("1. Populate Dictionary");
            Console.WriteLine("2. Display Dictionary");
            Console.WriteLine("3. Remove a Key");
            Console.WriteLine("4. Add a New Key and Value");
            Console.WriteLine("5. Add a Value to an Existing Key");
            Console.WriteLine("6. Sort the Keys");
            Console.WriteLine("7. Exit");

            // Gets the user's menu selection.
            Console.Write("\nChoose an option: ");
            string choice = Console.ReadLine();

            // Determines which action to perform based on the selection.
            switch (choice)
            {
                // OPTION 1: Populate the dictionary.
                case "1":

                    // Adds car manufacturers and their models.
                    cars["Toyota"] = new List<string>
                    {
                        "Camry", "Corolla"
                    };

                    cars["Honda"] = new List<string>
                    {
                        "Civic", "Accord"
                    };

                    cars["Ford"] = new List<string>
                    {
                        "Mustang", "F-150"
                    };

                    cars["BMW"] = new List<string>
                    {
                        "X5", "3 Series"
                    };

                    cars["Chevrolet"] = new List<string>
                    {
                        "Camaro", "Corvette"
                    };

                    Console.WriteLine("Car dictionary populated!");
                    break;

               // Displays the dictionary contents.
                case "2":

                    Console.WriteLine("\nCar Dictionary Contents:");

                    // Uses foreach to go through each pair and display the manufacturer and its models.
                   
                    foreach (var car in cars)
                    {
                        Console.WriteLine(car.Key + ": " +
                            string.Join(", ", car.Value));
                    }
                    break;

                // Remove a manufacturer from the dictionary.
                case "3":

                    Console.Write("Enter the manufacturer to remove: ");
                    string removeKey = Console.ReadLine().Trim();

                    // Checks whether the key exists and removes it.
                    if (cars.Remove(removeKey))
                    {
                        Console.WriteLine("Manufacturer removed successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Manufacturer not found.");
                    }
                    break;

                //  Add a new manufacturer and car model.
                case "4":

                    Console.Write("Enter a new manufacturer: ");
                    string newKey = Console.ReadLine().Trim();

                    // Checks whether the manufacturer already exists.
                    if (cars.ContainsKey(newKey))
                    {
                        Console.WriteLine("That manufacturer already exists.");
                    }
                    else
                    {
                        // Gets the model associated with the new manufacturer.
                        Console.Write("Enter a car model: ");
                        string newValue = Console.ReadLine().Trim();

                        // Adds the new key and its value to the dictionary.
                        cars[newKey] = new List<string> { newValue };

                        Console.WriteLine("New manufacturer and model added!");
                    }
                    break;

                // Add another model to an existing manufacturer.
                case "5":

                    Console.Write("Enter an existing manufacturer: ");
                    string existingKey = Console.ReadLine().Trim();

                    // Checks whether the manufacturer is already in the dictionary.
                    if (cars.ContainsKey(existingKey))
                    {
                        Console.Write("Enter another car model: ");
                        string addedValue = Console.ReadLine().Trim();

                        // Adds the new model to the manufacturer's existing list.
                        cars[existingKey].Add(addedValue);

                        Console.WriteLine("New car model added!");
                    }
                    else
                    {
                        Console.WriteLine("Manufacturer not found.");
                    }
                    break;

                //  Displays the manufacturer keys alphabetically.
                case "6":

                    Console.WriteLine("\nCar Manufacturers (Alphabetical Order):");

                    // Uses OrderBy to sort the keys alphabetically
                
                    foreach (var key in cars.Keys.OrderBy(k => k))
                    {
                        Console.WriteLine(key);
                    }
                    break;

                //  Exit the program.
                case "7":

                    // Changes running to false so the while loop stops.
                    running = false;
                    Console.WriteLine("Exiting Car Dictionary. Goodbye!");
                    break;

                // Handles selections that are not listed in the menu.
                default:

                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}

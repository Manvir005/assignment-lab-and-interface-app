using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static List<Appliance> appliances;

    static void Main()
    {
        // Load appliances from the file
        appliances = FileHandler.LoadAppliancesFromFile("appliances.txt");

        // Main menu loop
        while (true)
        {
            Console.WriteLine("Welcome to Modern Appliances!");
            Console.WriteLine("How May We Assist You?");
            Console.WriteLine("1 – Check out appliance");
            Console.WriteLine("2 – Find appliances by brand");
            Console.WriteLine("3 – Display appliances by type");
            Console.WriteLine("4 – Produce random appliance list");
            Console.WriteLine("5 – Save & exit");
            Console.Write("Enter option: ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    CheckOutAppliance();
                    break;
                case "2":
                    FindByBrand();
                    break;
                case "3":
                    DisplayByType();
                    break;
                case "4":
                    ProduceRandomList();
                    break;
                case "5":
                    FileHandler.SaveAppliancesToFile("appliances.txt", appliances);
                    return;
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }
    }

    static void CheckOutAppliance()
    {
        Console.Write("Enter the item number of an appliance: ");
        long itemNumber = long.Parse(Console.ReadLine());
        var appliance = appliances.FirstOrDefault(a => a.ItemNumber == itemNumber);
        if (appliance == null)
        {
            Console.WriteLine("No appliances found with that item number.");
        }
        else
        {
            appliance.Checkout();
        }
    }

    static void FindByBrand()
    {
        Console.Write("Enter brand to search for: ");
        string brand = Console.ReadLine();
        var matching = appliances.Where(a => a.Brand.Equals(brand, StringComparison.OrdinalIgnoreCase)).ToList();
        if (matching.Count == 0)
        {
            Console.WriteLine("No appliances found.");
        }
        else
        {
            Console.WriteLine("Matching Appliances:");
            foreach (var a in matching)
            {
                Console.WriteLine(a.ToString());
            }
        }
    }

    static void DisplayByType()
    {
        Console.WriteLine("Appliance Types\n1 – Refrigerators\n2 – Vacuums");
        Console.Write("Enter type of appliance: ");
        string type = Console.ReadLine();

        switch (type)
        {
            case "1": // Refrigerators
                Console.Write("Enter number of doors: 2 (double door), 3 (three doors) or 4 (four doors): ");
                int doors = int.Parse(Console.ReadLine());
                var fridges = appliances.OfType<Refrigerator>().Where(f => f.NumberOfDoors == doors).ToList();
                if (fridges.Count == 0)
                {
                    Console.WriteLine("No refrigerators found.");
                }
                else
                {
                    Console.WriteLine("Matching refrigerators:");
                    foreach (var f in fridges)
                    {
                        Console.WriteLine(f.ToString());
                    }
                }
                break;
            case "2": // Vacuums
                Console.Write("Enter battery voltage value. 18 V (low) or 24 V (high): ");
                int voltage = int.Parse(Console.ReadLine());
                var vacuums = appliances.OfType<Vacuum>().Where(v => v.BatteryVoltage == voltage).ToList();
                if (vacuums.Count == 0)
                {
                    Console.WriteLine("No vacuums found.");
                }
                else
                {
                    Console.WriteLine("Matching vacuums:");
                    foreach (var v in vacuums)
                    {
                        Console.WriteLine(v.ToString());
                    }
                }
                break;
            default:
                Console.WriteLine("Invalid type.");
                break;
        }
    }

    static void ProduceRandomList()
    {
        Console.Write("Enter number of appliances: ");
        int num = int.Parse(Console.ReadLine());
        var random = new Random();
        var randomList = appliances.OrderBy(a => random.Next()).Take(num).ToList();
        Console.WriteLine("Random appliances:");
        foreach (var a in randomList)
        {
            Console.WriteLine(a.ToString());
        }
    }
}

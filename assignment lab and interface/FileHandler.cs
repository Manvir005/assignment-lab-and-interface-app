using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class FileHandler
{
    public static List<Appliance> LoadAppliancesFromFile(string filePath)
    {
        List<Appliance> appliances = new List<Appliance>();
        if (!File.Exists(filePath))
        {
            Console.WriteLine("File not found.");
            return appliances;
        }

        var lines = File.ReadAllLines(filePath);
        foreach (var line in lines)
        {
            var data = line.Split(';');
            long itemNumber = long.Parse(data[0]);
            string brand = data[1];
            int quantity = int.Parse(data[2]);
            int wattage = int.Parse(data[3]);
            string color = data[4];
            double price = double.Parse(data[5]);

            switch (itemNumber.ToString()[0])
            {
                case '1': // Refrigerator
                    appliances.Add(new Refrigerator(itemNumber, brand, quantity, wattage, color, price, int.Parse(data[6]), int.Parse(data[7]), int.Parse(data[8])));
                    break;
                case '2': // Vacuum
                    appliances.Add(new Vacuum(itemNumber, brand, quantity, wattage, color, price, data[6], int.Parse(data[7])));
                    break;
            }
        }
        return appliances;
    }

    public static void SaveAppliancesToFile(string filePath, List<Appliance> appliances)
    {
        var lines = new List<string>();
        foreach (var appliance in appliances)
        {
            if (appliance is Refrigerator fridge)
            {
                lines.Add($"{fridge.ItemNumber};{fridge.Brand};{fridge.Quantity};{fridge.Wattage};{fridge.Color};{fridge.Price};{fridge.NumberOfDoors};{fridge.Height};{fridge.Width}");
            }
            else if (appliance is Vacuum vacuum)
            {
                lines.Add($"{vacuum.ItemNumber};{vacuum.Brand};{vacuum.Quantity};{vacuum.Wattage};{vacuum.Color};{vacuum.Price};{vacuum.Grade};{vacuum.BatteryVoltage}");
            }
        }
        File.WriteAllLines(filePath, lines);
        Console.WriteLine("Appliances saved to file.");
    }
}

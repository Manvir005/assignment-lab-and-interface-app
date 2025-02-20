class Vacuum : Appliance
{
    public string Grade { get; set; }
    public int BatteryVoltage { get; set; }

    public Vacuum(long itemNumber, string brand, int quantity, int wattage, string color, double price, string grade, int batteryVoltage)
        : base(itemNumber, brand, quantity, wattage, color, price)
    {
        Grade = grade;
        BatteryVoltage = batteryVoltage;
    }

    public override string ToString()
    {
        string voltageDescription = BatteryVoltage == 18 ? "Low" : "High";
        return $"Item Number: {ItemNumber}\n" +
               $"Brand: {Brand}\n" +
               $"Quantity: {Quantity}\n" +
               $"Wattage: {Wattage}\n" +
               $"Color: {Color}\n" +
               $"Price: {Price}\n" +
               $"Grade: {Grade}\n" +
               $"Battery Voltage: {voltageDescription}\n";
    }
}

class Refrigerator : Appliance
{
    public int NumberOfDoors { get; set; }
    public int Height { get; set; }
    public int Width { get; set; }

    public Refrigerator(long itemNumber, string brand, int quantity, int wattage, string color, double price, int numberOfDoors, int height, int width)
        : base(itemNumber, brand, quantity, wattage, color, price)
    {
        NumberOfDoors = numberOfDoors;
        Height = height;
        Width = width;
    }

    public override string ToString()
    {
        return $"Item Number: {ItemNumber}\n" +
               $"Brand: {Brand}\n" +
               $"Quantity: {Quantity}\n" +
               $"Wattage: {Wattage}\n" +
               $"Color: {Color}\n" +
               $"Price: {Price}\n" +
               $"Number of Doors: {NumberOfDoors}\n" +
               $"Height: {Height} inches\n" +
               $"Width: {Width} inches\n";
    }
}
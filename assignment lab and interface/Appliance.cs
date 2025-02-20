abstract class Appliance
{
    public long ItemNumber { get; set; }
    public string Brand { get; set; }
    public int Quantity { get; set; }
    public int Wattage { get; set; }
    public string Color { get; set; }
    public double Price { get; set; }

    public Appliance(long itemNumber, string brand, int quantity, int wattage, string color, double price)
    {
        ItemNumber = itemNumber;
        Brand = brand;
        Quantity = quantity;
        Wattage = wattage;
        Color = color;
        Price = price;
    }

    public abstract override string ToString();

    public bool IsAvailable()
    {
        return Quantity > 0;
    }

    public void Checkout()
    {
        if (IsAvailable())
        {
            Quantity--;
            Console.WriteLine($"Appliance \"{ItemNumber}\" has been checked out.");
        }
        else
        {
            Console.WriteLine("The appliance is not available to be checked out.");
        }
    }
}
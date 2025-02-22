public class Microwave : Appliance
{
    public int Capacity { get; set; }
    public string RoomType { get; set; }

    public Microwave(long itemNumber, string brand, int quantity, int wattage, string color, double price, 
                     int capacity, string roomType)
        : base(itemNumber, brand, quantity, wattage, color, price)
    {
        Capacity = capacity;
        RoomType = roomType;
    }

    public override string ToString()
    {
        return $"Item Number: {ItemNumber}\n" +
               $"Brand: {Brand}\n" +
               $"Quantity: {Quantity}\n" +
               $"Wattage: {Wattage}\n" +
               $"Color: {Color}\n" +
               $"Price: {Price:C}\n" +
               $"Capacity: {Capacity} L\n" +
               $"Room Type: {RoomType}\n";
    }
}

public class Dishwasher : Appliance
{
    public string Feature { get; set; }
    public int SoundRating { get; set; }
    public int SoundRatingQ { get; set; }
    public int SoundRatingQ1 { get; set; }

    public Dishwasher(long itemNumber, string brand, int quantity, int wattage, string color, double price, 
                      string feature, int soundRating, int soundRatingQ, int soundRatingQ1)
        : base(itemNumber, brand, quantity, wattage, color, price)
    {
        Feature = feature;
        SoundRating = soundRating;
        SoundRatingQ = soundRatingQ;
        SoundRatingQ1 = soundRatingQ1;
    }

    public override string ToString()
    {
        return $"Item Number: {ItemNumber}\n" +
               $"Brand: {Brand}\n" +
               $"Quantity: {Quantity}\n" +
               $"Wattage: {Wattage}\n" +
               $"Color: {Color}\n" +
               $"Price: {Price:C}\n" +
               $"Feature: {Feature}\n" +
               $"Sound Rating: {SoundRating} dB\n" +
               $"Sound Rating Q: {SoundRatingQ}\n" +
               $"Sound Rating Q1: {SoundRatingQ1}\n";
    }
}

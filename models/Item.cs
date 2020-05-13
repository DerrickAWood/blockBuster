using BlockBuster.Models;
namespace BlockBuster.Models
{
  public class Item : BaseEntry
  {
    public int Quanity { get; set; }
    public decimal Price { get; private set; }
  public Item(string title, int quanity, decimal price) : base(title)
  {
    Quanity = quanity;
    Price = price;
  }
  public void Purchase()
  {
    System.Console.WriteLine($"purchased: {Title}");
  }
  }
}
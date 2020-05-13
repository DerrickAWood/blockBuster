using System.Collections.Generic;
using System;

namespace BlockBuster.Models
{
  public class Shop : BaseEntry
  {
    public List<Item> Inventory { get; private set; } = new List<Item>();

    public Shop() : base("the shop")
    {
      Item candy = new Item("Candy", 10, 2.00m);
      Item popcorn = new Item("Popcorn", 5, 3.00m);
      Item drink = new Item("Drink", 10, 4.00m);
      Inventory.Add(candy);
      Inventory.Add(popcorn);
      Inventory.Add(drink);
    }
    internal void VisitShop()
    {
      System.Console.WriteLine("welcome to the shop");
      PrintItems();
      bool purchasing = true;
      while (purchasing)
      {
        System.Console.WriteLine("what would you like? or type leave to exit");
        string input = Console.ReadLine();
        if(input.ToLower() == "leave")
        {
          purchasing = false; 
        }
        else
        {
          purchaseItem(input);
        }
      }
    }

    private void purchaseItem(string itemName)
    {
      Item foundItem = Inventory.Find(item => item.Title.ToLower() == itemName.ToLower());
      if(foundItem != null)
      {
        if(foundItem.Quanity < 1)
        {
        System.Console.WriteLine($"out of {foundItem.Title}");
        return;
        }
      }
      foundItem.Quanity--;
      System.Console.WriteLine($"you purchased {foundItem.Title}");
    }

    public void PrintItems()
    {
      System.Console.WriteLine("Avalible Items");
      for(int i = 0; i < Inventory.Count; i++)
      {
        Item item = Inventory[i];
        if(item.Quanity > 0)
        {
          System.Console.WriteLine($"{i + 1} - {item.Title} Qty: {item.Quanity} ${item.Price} each");
        }
      }
    }
  }
}
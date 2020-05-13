using System;
using BlockBuster.Models;
namespace BlockBuster
{
  public class App
  {
   public Store store {get; set;}
   public bool running {get; private set;}

   public void Run()
   {
     store = new Store("BlockBuster");
     Console.Clear();
     store.Setup();
     running = true;

     while(running)
     {
       MakeSelection();
     }
   }

   private void MakeSelection()
   {
     System.Console.WriteLine("What would you like to go? rent / return / quit");
     string choice = Console.ReadLine();
     switch(choice)
     {
       case "rent":
       store.RentMovie();
       break;
       case "quit":
       running = false;
       System.Console.WriteLine("thanks");
       Console.ReadLine();
       break;
       case "return":
       store.ReturnMovie();
       break;
       default:
       System.Console.WriteLine("invalid selection");
       break;
     }
   }
  }
}
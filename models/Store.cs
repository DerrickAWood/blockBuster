using System;
using System.Collections.Generic;

namespace BlockBuster.Models
{
  public class Store
  {
    public List<Movie> Movies { get; private set; }
    public string Title {get; set;}

    public Store(string title)
    {
      Title = title;
      Movies = new List<Movie>();
    }

    public void Setup()
    {
      System.Console.WriteLine($"Welcome to {Title}!");
      Movie toyStory = new Movie("Toy Story");
      Movie onward = new Movie("on ward");
      Movies.Add(toyStory);
      Movies.Add(onward);
    }

    internal void PrintMovies()
    {
      System.Console.WriteLine("Available Movies:");
      for(int i = 0; i < Movies.Count; i++)
      {
        Movie movie = Movies[i];
        if(movie.Available)
        {
          System.Console.WriteLine($"{i + 1} - {movie.Title}");
        }
      }
    }

    internal void RentMovie()
    {
      PrintMovies();
      System.Console.WriteLine("Which movie?");
      string input = Console.ReadLine();
      int index; 
      if(int.TryParse(input, out index) != false && index - 1 < Movies.Count && index - 1 > -1)
      {
        Movie movie = Movies[index - 1];
        if(!movie.Available)
        {
          System.Console.WriteLine("that movie has been rented already");
        }
        else 
        {
          movie.Available = false;
          System.Console.WriteLine($"you've rented {movie.Title}");
        }
      }
      else
      {
        System.Console.WriteLine("invalid");
      }
    }

    internal void ReturnMovie()
    {
      
      System.Console.WriteLine("which movie?");
      string input = Console.ReadLine();
      int index;
      if(int.TryParse(input, out index) != false && index - 1 < Movies.Count && index - 1 > -1)
      {
        Movie movie = Movies[index - 1];
        if(movie.Available)
        {
          System.Console.WriteLine("already rented");
        }
        else
        {
          movie.Available = true;
          System.Console.WriteLine($"you rented {movie.Title}");
        }
      }
      else
      {
        System.Console.WriteLine("invalid");
      }
    }
  }
}
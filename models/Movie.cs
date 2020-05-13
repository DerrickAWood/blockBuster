namespace BlockBuster.Models
{
  public class Movie
  {
    public string Title {get; private set;}
    public bool Available {get; set;}
    public Movie(string title)
    {
      Title = title;
      Available = true;
    }
  }
}
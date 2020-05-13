namespace BlockBuster.Models
{
  public abstract class BaseEntry
  {
    public string Title { get; private set; }
    public BaseEntry(string title)
    {
      Title = title;
    }
  }
}
using System;

namespace MediaWorld.Domain.Abstracts
{
  public class Book : AAudio
  {
    public delegate void CasingDelegate(string s);
    public event CasingDelegate BookEvent;

    public void Open()
    {
      BookEvent("someone opened a book");
    }
    //practice with delegates
    public void ReadAction(Action<string> d)
    {
      var text = "Read The Book";
      d(text);
    }
    public void ReadDelegate(CasingDelegate d)
    {
      var text = "Read The Book";
      d(text);
    }

    public void ReadFunction(Func<string, string> d)
    {
      var text = "Read The Book";
      d(text);
    }
    public void Read(HowToRead r)
    {
      var text = "Read The Book";
      switch (r)
      {
        case HowToRead.Upper:
          System.Console.WriteLine(text.ToUpperInvariant());
          break;

        case HowToRead.Lower:
          System.Console.WriteLine(text.ToLowerInvariant());
          break;
      }
    }
  }

  public enum HowToRead
  {
    Upper, Lower
  }
}
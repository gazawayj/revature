using MediaWorld.Domain.Abstracts;

namespace MediaWorld.Domain.Models
{
  public class Song : AMedia
  {
    public Song()
    {
      
    }
    public Song(string _name)
    {
      Title = _name;
    }
  }
}
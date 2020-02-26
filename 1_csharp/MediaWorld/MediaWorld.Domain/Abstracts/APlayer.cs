using MediaWorld.Domain.Abstracts;

namespace MediaWorld.Domain.Interfaces
{
  public abstract class APlayer : IPlayer
  {
    public void Play(AMedia m)
    {
      System.Console.WriteLine("Playing '{0}'", m.Title);
    }

    public void Stop(AMedia m)
    {
      System.Console.WriteLine("Stopping '{0}'", m.Title);
    }
  }
}
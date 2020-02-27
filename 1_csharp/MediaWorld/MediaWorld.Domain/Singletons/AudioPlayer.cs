using MediaWorld.Domain.Interfaces;

namespace MediaWorld.Domain.Singletons
{
  public class AudioPlayer : APlayer
  {
    private static AudioPlayer _instance = new AudioPlayer();
    public static AudioPlayer Instance
    {
      get
      {
        return _instance;
      }
    }
    private AudioPlayer()
    {
    }
  }
}
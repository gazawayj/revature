using MediaWorld.Domain.Interfaces;

namespace MediaWorld.Domain.Singletons
{
  public class VideoPlayer : APlayer
  {
    private static VideoPlayer _Instance = new VideoPlayer();
    public static VideoPlayer Instance
    {
      get
      {
        return _Instance;
      }
    }
    private VideoPlayer()
    {
    }
  }
}
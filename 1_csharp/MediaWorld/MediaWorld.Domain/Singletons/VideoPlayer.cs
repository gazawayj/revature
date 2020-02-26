using System;
using MediaWorld.Domain.Interfaces;

namespace MediaWorld.Domain.Models
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
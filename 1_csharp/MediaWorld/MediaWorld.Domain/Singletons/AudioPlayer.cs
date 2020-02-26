using System;
using MediaWorld.Domain.Abstracts;
using MediaWorld.Domain.Interfaces;

namespace MediaWorld.Domain.Models
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
using System.Security.Cryptography;
using MediaWorld.Domain.Abstracts;

namespace MediaWorld.Domain.Interfaces
{
  public interface IPlayer
  {
    void Play(AMedia m);
    void Stop(AMedia m);
  }
}

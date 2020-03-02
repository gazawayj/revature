using System.Collections.Generic;
using MediaWorld.Domain.Abstracts;
using MediaWorld.Storage.Adapters;

namespace MediaWorld.Storage.Repositories
{
  public class AudioRepository
  {
    private static readonly List<AAudio> _lib =FileAdapter.Read() as List<AAudio>;

    public IEnumerable<AAudio> Lib()
    {
      return _lib;
    }

    public AudioRepository()
    {
    }
  }
}
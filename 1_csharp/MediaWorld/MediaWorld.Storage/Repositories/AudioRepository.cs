using System.Collections.Generic;
using MediaWorld.Domain.Abstracts;
using MediaWorld.Domain.Models;
using MediaWorld.Storage.Adapters;

namespace MediaWorld.Storage.Repositories
{
  public class AudioRepository
  {
    private readonly List<Song> _lib;

    public IEnumerable<Song> Lib()
    {
      return _lib;
    }

    public AudioRepository()
    {
      if (_lib == null)
      {
        _lib = FileAdapter.Read() as List<Song>;
      }
    }
  }
}
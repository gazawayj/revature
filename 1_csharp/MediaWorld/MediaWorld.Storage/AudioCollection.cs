using System.Collections.Generic;
using System.Linq;
using MediaWorld.Domain.Abstracts;
using MediaWorld.Domain.Models;

namespace MediaWorld.Storage
{
  public class AudioCollection
  {
    private Dictionary<string, AMedia> _audioDictionary;

    public AudioCollection()
    {
      _audioDictionary = new Dictionary<string, AMedia>();
    }

    public IEnumerable<AMedia> Playlist
    {
      get
      {
        return _audioDictionary.Values.ToList() ?? new List<AMedia>();
      }
    }

    public void AddSong(string _name)
    {
      System.Console.WriteLine("Song '{0}' added to playlist.", _name);
      _audioDictionary.Add(_audioDictionary.Count+"", new Song(_name));
    }
  }
}
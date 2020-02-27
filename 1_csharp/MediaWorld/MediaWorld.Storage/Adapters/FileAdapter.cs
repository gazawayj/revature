using System.Xml.Serialization;
using System.IO;
using System.Collections.Generic;
using MediaWorld.Domain.Abstracts;
using MediaWorld.Domain.Models;

namespace MediaWorld.Storage.Adapters
{
  public class FileAdapter
  {
    //literal string
    private static string path = @"../medialib.xml";
    private static string pathw = @"../medialibWrite.xml";
    public static IEnumerable<AMedia> Read()
    {
      var reader = new StreamReader(path);
      //begin DE - serialization
      var xml = new XmlSerializer(typeof(List<Song>));
      var la = xml.Deserialize(reader) as List<Song>;
      //have to cast to amedia
      return la;
    }

    public static void Write()
    {
      var writer = new StreamWriter(pathw);
      var xml = new XmlSerializer(typeof(List<AMedia>));
      var lib = new List<AMedia>();
      lib.Add(new Song("Please work"));
      xml.Serialize(writer, lib);
    }
  }
}
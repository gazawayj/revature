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
    public static IEnumerable<AMedia> Read()
    {
      var reader = new StreamReader(path);
      //begin DE - serialization
      var xml = new XmlSerializer(typeof(List<AMedia>), new []{typeof(Book), typeof(Song)});
      return xml.Deserialize(reader) as List<AMedia>;
    }
  }
}
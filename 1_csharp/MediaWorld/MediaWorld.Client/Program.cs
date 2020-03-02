using System;
using MediaWorld.Domain.Models;
using MediaWorld.Storage.Adapters;
using MediaWorld.Domain.Singletons;
using MediaWorld.Storage;
using MediaWorld.Storage.Repositories;
using MediaWorld.Domain.Abstracts;

namespace MediaWorld.Client
{
    internal class Program
    {
      private static readonly AudioRepository repo = new AudioRepository();

        private static void Main(string[] args)
        {
            //PlayAudio();
            PlayBook();
        }

        private static void PlayBook()
        {
          var b = new Book();
          //b.Read(HowToRead.Lower);
          // b.ReadAction((string s) => { Console.WriteLine(s.ToLowerInvariant()); });
          // b.ReadFunction((string s) => { Console.WriteLine(s.ToUpperInvariant()); return string.Empty; });
          // b.ReadDelegate((string s) => { Console.WriteLine(s.ToLowerInvariant()); });

          //event 
          b.BookEvent += UseEvent;
          b.Open();
        }

        public static void UseEvent(string s)
        {
          System.Console.WriteLine("we heard you");
        }

        private void UseCasingDelegate(string s)
        {
          System.Console.WriteLine(s);
        }
        
        private static void PlayAudio()
        {
          var repo2 = new AudioRepositoryGeneric<Song>();
          var repo3 = new AudioRepositoryGeneric<Book>();
          var ap = AudioPlayer.Instance;

          try 
          {
            foreach(var media in repo.Lib())
            {
              ap.Play(media);
            }
          } catch (Exception e)
          {
            System.Console.WriteLine(e.ToString());
          }
          finally
          {
            //Run the garbage collection
            GC.Collect();
          }
        }

    private static void PlayVideo()
        {
          var vp = VideoPlayer.Instance;
        }
    }
}
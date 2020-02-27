using System;
using MediaWorld.Domain.Models;
using MediaWorld.Storage.Adapters;
using MediaWorld.Domain.Singletons;
using MediaWorld.Storage;
using MediaWorld.Storage.Repositories;

namespace MediaWorld.Client
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            PlayAudio();
            //FileAdapter.Write();
        }

        private static void PlayAudio()
        {
          var ap = AudioPlayer.Instance;
          //var ac = new AudioCollection();
          var repo = new AudioRepository();

          //Lazyily create some songs
          //PropegateSomeSongs(ac);

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

    private static void PropegateSomeSongs(AudioCollection ac)
    {
        Random random = new Random();
        int num = random.Next(0, 25);
        for (int i = 0; i < num; i++)
        {
          //create some random strings
          //create songs from them and add them to the audio collection
        }
    }

    private static void PlayVideo()
        {
          var vp = VideoPlayer.Instance;
        }
    }
}
﻿using System;
using MediaWorld.Domain.Abstracts;
using MediaWorld.Domain.Models;

namespace MediaWorld.Client
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Program a = new Program();
            PlayAudio();
        }

        private static void PlayAudio()
        {
          var ap = AudioPlayer.Instance;
          ap.Play(new Song("Some Song Whose Title I can't Think Of"));
        }

        private static void PlayVideo()
        {
          var vp = VideoPlayer.Instance;
        }
    }
}

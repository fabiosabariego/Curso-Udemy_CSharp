using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading;

namespace Ex28_InheritanceVideoPost
{
    internal class VideoPost : Post
    {
        // Member Fields
        protected bool isPlaying = false;
        protected int currentDuration = 0;
        Timer timer;        // Vem do System.Threading

        // Properties
        protected string VideoURL { get; set; }
        protected int Length { get; set; }


        public VideoPost() { }


        public VideoPost(string title, string username, string videoURL, bool isPublic, int length)
        {
            // Os parametros abaixos foram herdados da Classe mae
            this.ID = GetNextID();
            this.Title = title;
            this.UserName = username;
            this.IsPublic = isPublic;
            // Os parametros abaixo sao referentes a essa classe
            this.VideoURL = videoURL;
            this.Length = length;
        }

        public override string ToString()
        {
            return String.Format($"{this.ID} - {this.Title} --> {this.VideoURL} <-- with {Length}s - by {this.UserName}");
        }

        private void TimerCallback(Object o)
        {
            if (currentDuration < Length)
            {
                currentDuration++;
                Console.WriteLine($"Video at {currentDuration}s");
                GC.Collect();
            }
            else
            {
                Stop();
            }
        }

        public void Play()
        {
            if (!isPlaying)
            {
                isPlaying = true;
                Console.WriteLine("Playing");
                timer = new Timer(TimerCallback, null, 0, 1000);
            }
            
        }

        public void Stop()
        {
            if (isPlaying)
            {
                isPlaying = false;
                Console.WriteLine($"Stopped at {currentDuration}");
                currentDuration = 0;
                timer.Dispose();
            }
        }


    }

}

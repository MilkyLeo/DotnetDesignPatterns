using System;

namespace AdapterPattern
{
    public class VlcPlayer : IAdvancedMediaPlayer
    {
        public void PlayVlc(string fileName)
        {
            Console.WriteLine("Playing vlc file. Name: " + fileName);
        }

        public void PlayMp4(string fileName)
        {
            //Do nothing
        }
    }
}
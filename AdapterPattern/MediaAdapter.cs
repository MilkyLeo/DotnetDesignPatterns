using System;

namespace AdapterPattern
{
    public class MediaAdapter : IMediaPlayer
    {
        private readonly IAdvancedMediaPlayer _advancedMedia;

        public MediaAdapter(string audioType)
        {
            if (String.Equals(audioType, "vlc"))
            {
                _advancedMedia = new VlcPlayer();
            }
            else if (String.Equals(audioType, "mp4"))
            {
                _advancedMedia = new Mp4Player();
            }
        }
        public void Play(string audioType, string fileName)
        {
            if (String.Equals(audioType, "vlc"))
            {
                _advancedMedia.PlayVlc(fileName);
            }
            else if (String.Equals(audioType, "mp4"))
            {
                _advancedMedia.PlayMp4(fileName);
            }
        }
    }
}
namespace AdapterPattern
{
    //Combines the capability of two independent interfaces.

    internal class Program
    {
        private static void Main()
        {
            var audioPlayer = new AudioPlayer();

            audioPlayer.Play("mp3", "Beyond the horizon.mp3");
            audioPlayer.Play("mp4", "Alone.mp4");
            audioPlayer.Play("vlc", "Far far away.vlc");
            audioPlayer.Play("avi", "Mind me.avi");
        }
    }
}

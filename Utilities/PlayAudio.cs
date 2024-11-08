using System.Media;
using System.Runtime.InteropServices;
using LibVLCSharp.Shared;

public class AudioPlayer
{
    private static SoundPlayer? soundPlayer;

    public static void StartBackgroundMusic()
    {
        if (!RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            return;
        }

        string ambientMusicFilePath = "./Audio/The Foyer.wav";

        if (soundPlayer == null)
        {
            soundPlayer = new SoundPlayer();
        }

        soundPlayer.SoundLocation = ambientMusicFilePath;
        soundPlayer.PlayLooping();
    }

    public static void StopBackgroundMusic()
    {
        if (!RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            return;
        }

        if (soundPlayer == null)
        {
            soundPlayer = new SoundPlayer();
        }

        soundPlayer.Stop();
    }

    public static void PlaySound(string audioPath)
    {
        if (!RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            return;
        }

        LibVLC libVLC = new LibVLC();
        MediaPlayer mediaPlayer = new MediaPlayer(libVLC);

        Media media = new Media(libVLC, audioPath, FromType.FromPath);

        mediaPlayer.Media = media;
        mediaPlayer.Volume = 400;

        mediaPlayer.Play();
    }
}

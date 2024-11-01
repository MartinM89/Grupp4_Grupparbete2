using System.Media;
using System.Runtime.InteropServices;
using LibVLCSharp.Shared;

public class Audio
{
    private static SoundPlayer? soundPlayer;

    public static void BackgroundMusic()
    {
        if (!RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            return;
        }

        // Initialize libVLC with the correct path to native libraries
        Core.Initialize();

        string ambientMusicFilePath = "./Audio/The Foyer (LOUD).wav";

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

        string ambientMusicFilePath = "./Audio/The Foyer.wav";

        if (soundPlayer == null)
        {
            soundPlayer = new SoundPlayer();
        }

        soundPlayer.SoundLocation = ambientMusicFilePath;
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
        mediaPlayer.Volume = 100;

        mediaPlayer.Play();
    }
}

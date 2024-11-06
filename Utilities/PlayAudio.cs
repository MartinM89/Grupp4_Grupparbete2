using System.Media;
using LibVLCSharp.Shared;
using System.Runtime.InteropServices;

public class AudioPlayer
{
    private static SoundPlayer? soundPlayer;

    public static void StartBackgroundMusic()
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
        mediaPlayer.Volume = 100;

        mediaPlayer.Play();
    }
}

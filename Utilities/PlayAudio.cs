using System.Media;
using System.Runtime.InteropServices;

public class PlayAudio
{
    private static SoundPlayer? soundPlayer;

    public static void PlayBackgroundMusic()
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

        soundPlayer.SoundLocation = ambientMusicFilePath!;
        soundPlayer.PlayLooping();
    }
}

// using LibVLCSharp.Shared;

// public class PlayAudio
// {
//     private static LibVLC? libVLC;
//     private static MediaPlayer? mediaPlayer;

//     public static void PlayBackgroundMusic()
//     {
//         // Initialize libVLC with the correct path to native libraries
//         Core.Initialize(Path.Combine(AppContext.BaseDirectory, "libvlc"));

//         if (libVLC == null)
//         {
//             libVLC = new LibVLC();
//             mediaPlayer = new MediaPlayer(libVLC);
//         }

//         string ambientMusicFilePath = "./Audio/The Foyer.wav";

//         Media media = new Media(libVLC, ambientMusicFilePath, FromType.FromPath);
//         mediaPlayer!.Media = media;
//         mediaPlayer.Volume = 25;
//         mediaPlayer.Play();
//     }
// }
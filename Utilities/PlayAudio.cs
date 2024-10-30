// using System.Media;
// using System.Runtime.InteropServices;

// public class PlayAudio
// {
//     private static SoundPlayer? soundPlayer;

//     public static void PlayBackgroundMusic()
//     {
//         if (!RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
//         {
//             return;
//         }

//         string ambientMusicFilePath = "./Audio/The Foyer.wav";
//         string journal_read_audio = ".Audio/Audio/journal_read.wav";
//         string lightbulb_screw_audio = "./Audio/Audio/lightbulb_screw.wav";
//         string mirror_move_audio = ".Audio/Audio/mirror_move.wav";
//         string rug_cut_audio = ".Audio/Audio/rug_cut.wav";
//         string tapestry_rip_audio = ".Audio/Audio/tapestry_rip.wav";
//         string tapestry_scraper_rip_audio = ".Audio/Audio/tapestry_scraper_rip.wav";
//         string wardrobe_crowbar_creak_audio = ".Audio/Audio/wardrobe_crowbar_creak.wav";
//         string window_wind_audio = ".Audio/Audio/window_wind.wav";

//         if (soundPlayer == null)
//         {
//             soundPlayer = new SoundPlayer();
//         }

//         soundPlayer.SoundLocation = ambientMusicFilePath!;
//         soundPlayer.PlayLooping();
//     }
// }

using LibVLCSharp.Shared;

public class PlayAudio
{
    // private static LibVLC? libVLC = new LibVLC();
    // private static MediaPlayer? mediaPlayer;

    public static void PlayBackgroundMusic()
    {
        // Initialize libVLC with the correct path to native libraries
        Core.Initialize();

        LibVLC? libVLC = new LibVLC();
        MediaPlayer? mediaPlayer = new MediaPlayer(libVLC!);

        string ambientMusicFilePath = "./Audio/The Foyer.wav";

        Media media = new Media(libVLC!, ambientMusicFilePath, FromType.FromPath);
        mediaPlayer!.Media = media;
        mediaPlayer.Volume = 100;
        mediaPlayer.Play();
    }
}

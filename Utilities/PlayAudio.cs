using System.Media;
using System.Runtime.InteropServices;

public class PlayAudio
{
    private static SoundPlayer? soundPlayer;

    public static void BackgroundMusic()
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

        string ambientMusicFilePath = "./Audio/The Foyer.wav";

        if (soundPlayer == null)
        {
            soundPlayer = new SoundPlayer();
        }

        soundPlayer.SoundLocation = ambientMusicFilePath;
        soundPlayer.Stop();
    }

    public static void Journal()
    {
        if (!RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            return;
        }

        string journal_read_audio = "./Audio/Audio/journal_read.wav";

        if (soundPlayer == null)
        {
            soundPlayer = new SoundPlayer();
        }

        soundPlayer.SoundLocation = journal_read_audio;
        soundPlayer.PlaySync();

        BackgroundMusic();
    }

    public static void Lightbuld()
    {
        if (!RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            return;
        }

        string lightbulb_screw_audio = "./Audio/Audio/lightbulb_screw.wav";

        if (soundPlayer == null)
        {
            soundPlayer = new SoundPlayer();
        }

        soundPlayer.SoundLocation = lightbulb_screw_audio;
        soundPlayer.PlaySync();

        BackgroundMusic();
    }

    public static void Mirror()
    {
        if (!RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            return;
        }

        string mirror_move_audio = "./Audio/Audio/mirror_move.wav";

        if (soundPlayer == null)
        {
            soundPlayer = new SoundPlayer();
        }

        soundPlayer.SoundLocation = mirror_move_audio;
        soundPlayer.PlaySync();

        BackgroundMusic();
    }

    public static void RugCut()
    {
        if (!RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            return;
        }

        string rug_cut_audio = "./Audio/Audio/rug_cut.wav";

        if (soundPlayer == null)
        {
            soundPlayer = new SoundPlayer();
        }

        soundPlayer.SoundLocation = rug_cut_audio;
        soundPlayer.PlaySync();

        BackgroundMusic();
    }

    public static void TapestryRip()
    {
        if (!RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            return;
        }

        string tapestry_rip_audio = "./Audio/Audio/tapestry_rip.wav";

        if (soundPlayer == null)
        {
            soundPlayer = new SoundPlayer();
        }

        soundPlayer.SoundLocation = tapestry_rip_audio;
        soundPlayer.PlaySync();

        BackgroundMusic();
    }

    public static void TapestryScraper()
    {
        if (!RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            return;
        }

        string tapestry_scraper_rip_audio = "./Audio/Audio/tapestry_scraper.wav";

        if (soundPlayer == null)
        {
            soundPlayer = new SoundPlayer();
        }

        soundPlayer.SoundLocation = tapestry_scraper_rip_audio;
        soundPlayer.PlaySync();

        BackgroundMusic();
    }

    public static void WardrobeCrowbar()
    {
        if (!RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            return;
        }

        string wardrobe_crowbar_creak_audio = "./Audio/Audio/wardrobe_crowbar_creak.wav";

        if (soundPlayer == null)
        {
            soundPlayer = new SoundPlayer();
        }

        soundPlayer.SoundLocation = wardrobe_crowbar_creak_audio;
        soundPlayer.PlaySync();

        BackgroundMusic();
    }

    public static void Wind()
    {
        if (!RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            return;
        }

        string window_wind_audio = "./Audio/Audio/window_wind.wav";

        if (soundPlayer == null)
        {
            soundPlayer = new SoundPlayer();
        }

        soundPlayer.SoundLocation = window_wind_audio;
        soundPlayer.PlaySync();

        BackgroundMusic();
    }

    public static void Dream()
    {
        if (!RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            return;
        }

        string dream_sequence_audio = "./Audio/Audio/dream_sequence.wav";

        if (soundPlayer == null)
        {
            soundPlayer = new SoundPlayer();
        }

        soundPlayer.SoundLocation = dream_sequence_audio;
        soundPlayer.PlaySync();

        BackgroundMusic();
    }

    public static void Secret()
    {
        if (!RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            return;
        }

        string find_secret_audio = "./Audio/Audio/find_secret.wav";

        if (soundPlayer == null)
        {
            soundPlayer = new SoundPlayer();
        }

        soundPlayer.SoundLocation = find_secret_audio;
        soundPlayer.PlaySync();

        BackgroundMusic();
    }
}
























// using LibVLCSharp.Shared;

// public class PlayAudio
// {
//     public static void PlayBackgroundMusic()
//     {
//         // Initialize libVLC with the correct path to native libraries
//         Core.Initialize();

//         LibVLC libVLC = new LibVLC();
//         MediaPlayer mediaPlayer = new MediaPlayer(libVLC);

//         string ambientMusicFilePath = "./Audio/The Foyer.wav";
//         string journal_read_audio = "./Audio/Audio/journal_read.wav";
//         string lightbulb_screw_audio = "./Audio/Audio/lightbulb_screw.wav";
//         string mirror_move_audio = "./Audio/Audio/mirror_move.wav";
//         string rug_cut_audio = "./Audio/Audio/rug_cut.wav";
//         string tapestry_rip_audio = "./Audio/Audio/tapestry_rip.wav";
//         string tapestry_scraper_rip_audio = "./Audio/Audio/tapestry_scraper_rip.wav";
//         string wardrobe_crowbar_creak_audio = "./Audio/Audio/wardrobe_crowbar_creak.wav";
//         string window_wind_audio = "./Audio/Audio/window_wind.wav";

//         Media media = new Media(libVLC, journal_read_audio, FromType.FromPath);

//         mediaPlayer.Media = media;
//         mediaPlayer.Volume = 100;

//         mediaPlayer.Play();

//         mediaPlayer.EndReached += (sender, e) =>
//         {
//             mediaPlayer.Stop();
//             mediaPlayer.Play();
//         };
//     }
// }

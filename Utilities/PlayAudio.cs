using System.Media;
using System.Runtime.InteropServices;
using NAudio.Wave;

public static class AudioPlayer
{
    private static IAudioPlayer _audioPlayer;
    private static bool _isLooping = true;

    public static bool IsLooping
    {
        get { return _isLooping; }
        set
        {
            _isLooping = value;
            _audioPlayer?.SetLooping(_isLooping);
        }
    }

    public static void PlayBackgroundMusic(string filePath)
    {
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            _audioPlayer = new WindowsAudioPlayer();
        }
        else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
        {
            _audioPlayer = new MacAudioPlayer();
        }
        else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
        {
            // _audioPlayer = new LinuxAudioPlayer();
        }
        else
        {
            throw new PlatformNotSupportedException("Audio playback is not supported on this platform.");
        }

        _audioPlayer.Initialize(filePath);
        _audioPlayer.SetLooping(_isLooping);
        _audioPlayer.Play();
    }

    public static void Stop()
    {
        _audioPlayer?.Stop();
    }
}

public interface IAudioPlayer
{
    void Initialize(string filePath);
    void Play();
    void Pause();
    void Stop();
    void SetLooping(bool isLooping);
}

class WindowsAudioPlayer : IAudioPlayer
{
    private SoundPlayer _soundPlayer;

    public void Initialize(string filePath)
    {
        _soundPlayer = new SoundPlayer(filePath);
    }

    public void Play()
    {
        _soundPlayer.PlayLooping();
    }

    public void Pause()
    {
        _soundPlayer.Stop();
    }

    public void Stop()
    {
        _soundPlayer.Stop();
    }

    public void SetLooping(bool isLooping)
    {
        // No-op, SoundPlayer always plays in a loop
    }
}

class MacAudioPlayer : IAudioPlayer
{
    private AudioFileReader _audioFileReader;
    private WaveOutEvent _waveOutEvent;

    public void Initialize(string filePath)
    {
        _audioFileReader = new AudioFileReader(filePath);
        _waveOutEvent = new WaveOutEvent();
    }

    public void Play()
    {
        _waveOutEvent.Play();
        PlayLooping();
    }

    private void PlayLooping()
    {
        _audioFileReader.CurrentTime = TimeSpan.Zero;
        _waveOutEvent.Volume = 1.0f;
        _waveOutEvent.DesiredLatency = 100;
        _waveOutEvent.PlaybackStopped += WaveOutEvent_PlaybackStopped;
    }

    private void WaveOutEvent_PlaybackStopped(object? sender, StoppedEventArgs e)
    {
        if (AudioPlayer.IsLooping)
            PlayLooping();
    }

    public void Pause()
    {
        _waveOutEvent.Stop();
    }

    public void Stop()
    {
        _waveOutEvent.Stop();
        _audioFileReader.Dispose();
    }

    public void SetLooping(bool isLooping)
    {
        AudioPlayer.IsLooping = isLooping;
    }
}
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

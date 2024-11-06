public class InitializeGame
{
    public static void RunCommand()
    {
        // Initialize libVLC with the correct path to native libraries
        LibVLCSharp.Shared.Core.Initialize();

        Highscore.CreateLoadList();
        PuzzleManager.RandomizeSafeCode();

        Console.Clear();
        Inventory.letter.PrintFindItem();
        PressKeyToContinue.RunCommand();

        Console.Clear();
        HowToPlay.RunCommand();
        PressKeyToContinue.RunCommand();

        // AudioPlayer.StartBackgroundMusic();
    }
}

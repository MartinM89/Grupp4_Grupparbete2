public class InitializeGame
{
    public static void RunCommand()
    {
        Highscore.CreateLoadList();
        PuzzleManager.RandomizeSafeCode();

        Console.Clear();
        Inventory.letter.PrintFindItem();
        PressKeyToContinue.RunCommand();

        Console.Clear();
        HowToPlay.RunCommand();
        PressKeyToContinue.RunCommand();

        // Audio.StartBackgroundMusic();
    }
}

/*
Text baserat spel

* Command/Game Manager
    - Inventory - Check
    - Interact - Check
    - Exit - Check

* Safe
    - Password - Check

Classes:
* Objects (Any object)
    - Description - Check

    * Objects with letters (Journal, Light-bulb)
        - Hint for password (A = 1) - Check

    * Interactable objects (Tapestery, Safe)
        - Hides something - Check

    * Tool objects (Crowbar, Scraper)
        - Useable - Check
* Inventory
    - Add items - Check
    - Check items - Check

* Extra
    - High score - Check
    - Timer - Check
    - Bed - Sleep (Dream and lose time but gain another attempt) - Check
    - Key (Cheat) - Check
    - Ambient background music - Check
*/
class Program
{
    public static TimeSpan StartTime = DateTime.Now.TimeOfDay;
    public static bool running = true;
    public static bool leaveLocation = true;
    public static int attemptsLeft = 3;

    static void Main(string[] args)
    {
        Console.SetWindowSize(74, 23);

        Highscore.RunCommand();
        PuzzleManager.RandomizeSafeCode();

        // Console.Clear();
        // Inventory.letter.PrintFindItem();
        // PressKeyToContinue.RunCommand();

        Console.Clear();
        HowToPlay.RunCommand();
        PressKeyToContinue.RunCommand();

        PlayAudio.BackgroundMusic();

        while (running)
        {
            Console.Clear();

            PuzzleManager.PrintCode(); // Debugging
            PuzzleManager.PrintNumberCode(); // Debugging
            Console.WriteLine("*************************************************************************"); // Debugging

            Dialogue.PrintRoomDescription();

            string userInput = EnterInput.RunCommand();

            GameManager.TryExecuteCommand(userInput);
        }
    }
}

/*
    Cheat with key (If time allows)
        1. Three keys instead of one
            1. One behind painting.
            2. One inside the shoe
            3.
*/


/*
    Hur vi ska redovisa
    Vad vi ska redivisa
    Vem ska redovisa vad
    Testa ljud på bluetooth speaker

    Doll/Shoes TEXT
    Crowbar = RED
*/

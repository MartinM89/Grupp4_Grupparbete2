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
    - Key (Cheat)
    - Ambient music
*/

class Program
{
    public static TimeSpan StartTime = DateTime.Now.TimeOfDay;
    public static bool running = true;
    public static bool leaveLocation = true;
    public static int attemptsLeft = 3;
    static void Main(string[] args)
    {
        Highscore.RunCommand();
        PuzzleManager.RandomizeSafeCode();

        // Console.Clear();
        // Inventory.letter.PrintFindItem();
        // PressKeyToContinue.RunCommand();

        Console.Clear();
        HowToPlay.RunCommand();
        PressKeyToContinue.RunCommand();

        PlayAudio.PlayBackgroundMusic();

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
    Finished:
    Rug - Klar
    Crowbar - Klar
    Chessboard - Klar
    Mirror - Klar
    Painting - Klar
    Window - Klar
    Coat - Klar
    Tapestry - Klar
    Wardobe - Klar
    Bed - Klar
        / Scraper - Klar
    Table - Klar
        / Bulb - Klar
    Safe - Klar
        / Journal - Klar
*/

/*
    No wasted keypad attempts  // Klar - More testing
    Add audio effects
    Change color on keywords when fully investigated
    Cheat with key (If time allows)
        1. Key hidden behind painting
        2. Three keys instead of one
            1. One behind painting.
            2. One inside the shoe
            3.
*/

/*
    End Credits:
    Makers:
    Music: “The Foyer”, from PlayOnLoop.com
    Licensed under Creative Commons by Attribution 4.0
*/

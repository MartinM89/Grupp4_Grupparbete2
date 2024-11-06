class Program
{
    public static readonly TimeSpan StartTime = DateTime.Now.TimeOfDay;
    public static bool running = true;
    public static bool leaveLocation = true;

    static void Main(string[] args)
    {
        InitializeGame.RunCommand();

        while (running)
        {
            Console.Clear();

            Dialogue.PrintRoomDescription();

            string userInput = EnterInput.RunCommand();

            GameManager.TryExecuteCommand(userInput);
        }
    }
}

/*
    Print Character // Tony
    PressKeyToContinue // Du kan ta med båda (inte så lång kod)

    Audio // Martin

    Enter Input // Jimmy
    Invalid Input

    Location Manager // Martin
    Color

    Item // Tony - Object, Item och Letter
    Inventory // Tony - AddItem, CheckDuplicateItem, CheckToolInInventory, PrintInventory

    Location Chessboard // Jimmy
    Interaction Queen

    Highscore // Jimmy
*/

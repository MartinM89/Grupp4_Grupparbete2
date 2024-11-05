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
    PressKeyToContinue

    Audio // Martin

    Enter Input // Jimmy
    Invalid Input

    Color/Location Manager // Martin

    Item // Tony
    Inventory

    Location Chessboard // Jimmy
    Interaction Queen

    Highscore // Jimmy

    End Credits // Martin
*/

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

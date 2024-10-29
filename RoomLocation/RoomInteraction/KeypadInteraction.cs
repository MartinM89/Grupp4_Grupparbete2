class KeypadInteraction
{
    public static TimeSpan endTime = DateTime.Now.TimeOfDay;
    public static void RunCommand()
    {
        while (Program.attemptsLeft > 0)
        {
            Console.Clear();

            string textCode = Highscore.ConvertCodeToString();

            Console.WriteLine($"Attempts left: {Program.attemptsLeft}");

            string userCode = EnterCode.RunCommand();

            if (userCode.All(char.IsDigit) && userCode.Length.Equals(4))
            {
                if (userCode != textCode && userCode.Length.Equals(4))
                {
                    Console.Clear();
                    Program.attemptsLeft--;
                    Console.WriteLine("Wrong code.");
                    PressKeyToContinue.RunCommand();
                }
                else if (userCode.Equals(textCode))
                {
                    Highscore.Execute();
                    return;
                }
            }
            else
            {
                switch (userCode)
                {
                    case "inventory" or "inv":
                        CheckInventoryCommand.RunCommand();
                        break;

                    case "help":
                        HelpCommand.RunCommand();
                        break;

                    case "leave" or "":
                        return;

                    default:
                        InvalidInput.RunCommand(userCode);
                        break;
                }
            }
        }
        Console.Clear();
        Console.WriteLine("Game Over");
        PressKeyToContinue.RunCommand();
        ExitCommand.RunCommand();
    }
}

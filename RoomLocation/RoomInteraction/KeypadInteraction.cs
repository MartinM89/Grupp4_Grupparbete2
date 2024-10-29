class KeypadInteraction
{
    public static TimeSpan endTime = DateTime.Now.TimeOfDay;
    public static void RunCommand()
    {
        while (Program.attemptsLeft > 0)
        {
            Console.Clear();

            Console.WriteLine($"Attempts left: {Program.attemptsLeft}");

            string userCode = EnterCode.RunCommand();

            string textCode = "";

            foreach (int n in PuzzleManager.passwordNum)
            {
                textCode += n.ToString();
            }

            if (userCode.Equals("inventory") || userCode.Equals("inv"))
            {
                CheckInventoryCommand.RunCommand();
                continue;
            }
            else if (userCode.Equals("leave"))
            {
                return;
            }
            else if (userCode != textCode)
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
        Console.Clear();
        Console.WriteLine("Game Over");
        PressKeyToContinue.RunCommand();
        ExitCommand.RunCommand();
    }
}

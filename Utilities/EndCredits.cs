public class EndCredits
{
    public static void RunCommand()
    {
        Audio.StopBackgroundMusic();
        Console.SetWindowSize(74, 23);

        List<string> credits = new List<string>
        {
            "Producer:",
            "Tony Gullstrand",
            "Jimmy Johansson",
            "Martin Michail",
            "",
            "Game Design:",
            "Tony Gullstrand",
            "Jimmy Johansson",
            "Martin Michail",
            "",
            "Lead Developer:",
            "Tony Gullstrand",
            "Jimmy Johansson",
            "Martin Michail",
            "",
            "Text Writer:",
            "Martin Michail",
            "",
            "Music:",
            "The Foyer - PlayOnLoop.com",
            "Licensed under Creative Commons by Attribution 4.0",
            "",
            "Sound Producer:",
            "Tony Gullstrand",
            "",
            "",
            "",
            "",
            "Special Thanks:",
            "William Enander",
            "For leading this class somewhere...",
            "",
            "",
            "",
            "",
            "Thank you for playing our game!",
            "",
            ""
        };

        int terminalHeight = Console.WindowHeight;
        int terminalWidth = Console.WindowWidth;
        int creditsHeight = credits.Count;

        for (int i = 0; i < creditsHeight + terminalHeight; i++) // 40 + 23
        {
            Console.Clear();

            for (int j = 0; j < terminalHeight; j++)
            {
                int creditIndex = i + j - terminalHeight;

                if (creditIndex >= 0 && creditIndex < creditsHeight)
                {
                    string line = credits[creditIndex];
                    //   66
                    int centeredPosition = (terminalWidth - line.Length) / 2;  // (74 - 8) / 33
                    if (centeredPosition < 0) centeredPosition = 0;

                    Console.SetCursorPosition(centeredPosition, j);
                    Console.WriteLine(credits[creditIndex]);
                }
            }
            Thread.Sleep(250);
        }

        Console.SetCursorPosition((terminalWidth - 8) / 2, 10);
        Console.WriteLine("The End!");
        Console.ReadKey();
    }
}

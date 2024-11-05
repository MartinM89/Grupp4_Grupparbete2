public class PrintByCharacter
{
    public static void RunCommand(string input)
    {
        // int startLeft = Console.CursorLeft;
        // int startTop = Console.CursorTop;

        foreach (char c in input)
        {
            if (!Console.KeyAvailable)
            {
                Console.Write(c);
                Thread.Sleep(50);
                continue;
            }

            Console.ReadKey();
            Console.Clear();
            // Console.SetCursorPosition(startLeft, startTop);
            Console.Write(input);
            return;
        }
    }
}

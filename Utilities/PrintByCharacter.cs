public class PrintByCharacter
{
    public static void RunCommand(string input)
    {
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
            Console.Write(input);
            return;
        }
    }
}

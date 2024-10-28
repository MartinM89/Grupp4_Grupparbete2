public class PrintByCharacter
{
    public static void RunCommand(string input)
    {
        foreach (char c in input)
        {
            Console.Write(c);
            Thread.Sleep(50);
        }
    }
}
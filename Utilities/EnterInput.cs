public class EnterInput
{
    public static string RunCommand()
    {
        Console.Write("\nWrite command: ");
        string input = Console.ReadLine()!.ToLower().Replace(" ", "");
        return input;
    }
}

public class EnterCode
{
    public static string RunCommand()
    {
        Console.Write("\nEnter Code: ");
        string input = Console.ReadLine()!.ToLower().Replace(" ", "");
        return input;
    }
}

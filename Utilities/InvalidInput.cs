public class InvalidInput
{
    public static void RunCommand(string userInput)
    {
        if (string.IsNullOrEmpty(userInput))
        {
            Console.Write($"\nInvalid Input. "); Color.TextRed("NULL"); Console.Write(" does not exist.");
            Console.ReadKey();
        }
        else
        {
            Console.Write($"\nInvalid Input. "); Color.TextRed(userInput.ToUpper()); Console.Write(" does not exist.");
            Console.ReadKey();
        }
    }
}
public class PuzzleManager
{
    public static int[] passwordNum { get; private set; } = new int[4];
    public static char[] passwordChar { get; private set; } = new char[4];

    public static void RandomizeSafeCode()
    {
        Random random = new Random();

        List<int> availableNumbers = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9];

        for (int i = 0; i < 4; i++)
        {
            int randomIndex = random.Next(availableNumbers.Count);

            passwordNum[i] = availableNumbers[randomIndex];

            availableNumbers.RemoveAt(randomIndex);

            passwordChar[i] = passwordNum[i] switch
            {
                0 => 'G',
                1 => 'D',
                2 => 'F',
                3 => 'I',
                4 => 'B',
                5 => 'H',
                6 => 'C',
                7 => 'E',
                8 => 'J',
                9 => 'A',
                _ => ' '
            };
        }
    }

    public static void PrintCode()
    {
        foreach (char c in passwordChar)
        {
            Console.Write($"{char.ToUpper(c)} ");
        }
        Console.WriteLine();
    }

    public static string ConvertCodeToString()
    {
        string textCode = "";

        foreach (int n in PuzzleManager.passwordNum)
        {
            textCode += n.ToString();
        }
        return textCode;
    }

    public static void PrintNumberCode() // Debugging
    {
        foreach (int i in passwordNum)
        {
            Console.Write($"{i} ");
        }
        Console.WriteLine();
    }

}

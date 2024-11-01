public class PrintByCharacter
{
    public static void RunCommand(string input)
    {
        int startLeft = Console.CursorLeft;
        int startTop = Console.CursorTop;

        foreach (char c in input)
        {
            if (!Console.KeyAvailable)
            {
                Console.Write(c);
                Thread.Sleep(50);
                continue;
            }

            // Consume pressed key
            Console.ReadKey();

            // Clear pressed key
            Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop);
            Console.Write(" ");

            // Rewrite full text without delay
            Console.SetCursorPosition(startLeft, startTop);
            Console.Write(input);
            return;
        }
    }

    public static void OldRunCommand(string input)
    {
        foreach (char c in input)
        {
            Console.Write(c);
        }
    }
}

// 'enter' key creates new line
// public class PrintByCharacter
// {
//     public static void RunCommand(string input)
//     {
//         bool tst = true;
//         foreach (char c in input)
//         {
//             if (Console.KeyAvailable)
//             {
//                 Console.ReadKey();
//                 tst = false;
//                 Console.Write("\b");
//             }

//             Console.Write(c);

//             if (tst) Thread.Sleep(50);
//         }
//     }
// }

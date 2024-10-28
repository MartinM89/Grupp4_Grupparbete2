public class GameManager
{
    public static void TryExecuteCommand(string userInput)
    {
        switch (userInput)
        {
            case "rug":
                RugLocation.RunCommand();
                break;

            case "crowbar":
                CrowbarLocation.RunCommand();
                break;

            case "chessboard":
                ChessboardLocation.RunCommand();
                break;

            case "mirror":
                MirrorLocation.RunCommand();
                break;

            case "painting":
                PaintingLocation.RunCommand();
                break;

            case "window":
                WindowLocation.RunCommand();
                break;

            case "coat":
                CoatLocation.RunCommand();
                break;

            case "safe":
                SafeLocation.RunCommand();
                break;

            case "tapestry":
                TapestryLocation.RunCommand();
                break;
                
            case "wardrobe":
                Console.Clear();
                WardrobeLocation.RunCommand();
                break;

            case "bed":
                BedLocation.RunCommand();
                break;

            case "table":
                TableLocation.RunCommand();
                break;

            case "help":
                HelpCommand.RunCommand();
                break;

            case "inventory" or "inv":
                Console.Clear();
                CheckInventoryCommand.RunCommand();
                break;

            case "exit":
                ExitCommand.RunCommand();
                break;

            default:
                InvalidInput.RunCommand(userInput);
                break;
        }
    }
}
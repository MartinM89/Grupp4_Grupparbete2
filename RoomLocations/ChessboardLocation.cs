public class ChessboardLocation
{
    public static bool QueenAddedToInventory = false;

    public static void RunCommand()
    {
        if (QueenAddedToInventory)
        {
            Console.Clear();
            Dialogue.PrintChessboardEmptyDescription();
            ColorManager.SetInvestigated("chessboard");
            PressKeyToContinue.RunCommand();
        }

        while (!QueenAddedToInventory)
        {
            Console.Clear();
            Dialogue.PrintChessboardDescription();
            string userChoice = EnterInput.RunCommand();

            switch (userChoice)
            {
                case "queen":
                    QueenInteraction.RunCommand();
                    break;

                case "inventory" or "inv":
                    CheckInventoryCommand.RunCommand();
                    break;

                case "help":
                    HelpCommand.RunCommand();
                    break;

                case "leave" or "":
                    return;

                default:
                    InvalidInput.RunCommand(userChoice);
                    break;
            }
        }
    }
}

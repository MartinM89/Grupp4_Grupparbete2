public class MirrorLocation
{
    public static bool WalletAddedToInventory = false;

    public static void RunCommand()
    {
        if (WalletAddedToInventory)
        {
            Console.Clear();
            Dialogue.PrintMirrorEmptyDescription();
            PressKeyToContinue.RunCommand();
        }

        while (!WalletAddedToInventory)
        {
            Console.Clear();
            Dialogue.PrintMirrorDescription();
            string userChoice = EnterInput.RunCommand();

            switch (userChoice)
            {
                case "wallet":
                    WalletInteraction.RunCommand();
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
public class CoatLocation
{
    public static bool WatchAddedToInventory = false;
    public static bool CardAddedToInventory = false;
    public static void RunCommand()
    {
        if (WatchAddedToInventory && CardAddedToInventory)
        {
            Console.Clear();
            Dialogue.PrintEmptyCoatDescription();
            LocationManager.Investigated("coat");
            PressKeyToContinue.RunCommand();
        }

        while (!WatchAddedToInventory || !CardAddedToInventory)
        {
            Console.Clear();
            Dialogue.PrintCoatDescription();

            string userChoice = EnterInput.RunCommand();

            switch (userChoice)
            {
                case "watch":
                    PocketWatchInteraction.RunCommand();
                    break;

                case "card":
                    BusinessCardInteraction.RunCommand();
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

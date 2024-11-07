public class TableLocation
{
    public static bool LampshadeAddedToInventory = false;

    public static void RunCommand()
    {
        if (LampshadeAddedToInventory)
        {
            Console.Clear();
            Dialogue.PrintTableCompleteDescription();
            ColorManager.SetInvestigated("table");
            PressKeyToContinue.RunCommand();
        }

        while (!LampshadeAddedToInventory)
        {
            Console.Clear();

            Dialogue.PrintTableDescription();

            string userChoice = EnterInput.RunCommand();

            switch (userChoice)
            {
                case "lamp":
                    Console.Clear();
                    LampInteraction.RunCommand();
                    break;

                case "drawer":
                    Console.Clear();
                    DrawerInteraction.RunCommand();
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

public class DrawerInteraction
{
    public static Bulb bulb = new Bulb();

    public static void RunCommand()
    {
        bool canPickUp = Inventory.PLAYER_INVENTORY.CheckDuplicateTool(bulb);

        if (!canPickUp)
        {
            Console.Clear();
            Dialogue.PrintEmptyDrawerDescription();
            PressKeyToContinue.RunCommand();
            return;
        }

        while (true)
        {
            Console.Clear();
            Dialogue.PrintDrawerDescription();

            string userChoice = EnterInput.RunCommand();

            switch (userChoice)
            {
                case "bulb":
                    Console.Clear();
                    bulb.PrintFindItem();
                    Inventory.PLAYER_INVENTORY.AddTool(bulb);
                    return;

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

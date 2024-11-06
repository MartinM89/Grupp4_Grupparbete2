public class LampInteraction
{
    public static Lampshade lampshade = new Lampshade();
    public static void RunCommand()
    {
        bool canPickUp = Inventory.PLAYER_INVENTORY.CheckDuplicateItem(lampshade);

        if (!canPickUp)
        {
            Console.Clear();
            Dialogue.PrintEmptyLampDescription();
            PressKeyToContinue.RunCommand();
            return;
        }

        while (true)
        {
            Console.Clear();
            Dialogue.PrintLampDescription();

            string userChoice = EnterInput.RunCommand();

            switch (userChoice)
            {
                case "bulb":
                    string toolIsInInventory = Inventory.PLAYER_INVENTORY.CheckToolInInventory(userChoice);

                    if (userChoice.Equals(toolIsInInventory))
                    {
                        Console.Clear();
                        DrawerInteraction.bulb.UseTool();
                        AudioPlayer.PlaySound("./Audio/Audio/lightbulb_screw.wav");
                        PressKeyToContinue.RunCommand();
                        Console.Clear();
                        lampshade.PrintFindItem();
                        Inventory.PLAYER_INVENTORY.AddItem(lampshade);
                        TableLocation.LampshadeAddedToInventory = true;
                        return;
                    }
                    else
                    {
                        Console.Clear();
                        DrawerInteraction.bulb.MissingTool();
                        PressKeyToContinue.RunCommand();
                        break;
                    }

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

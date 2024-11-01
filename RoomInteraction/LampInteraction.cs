public class LampInteraction
{
    public static Lampshade lampshade = new Lampshade();
    public static void RunCommand()
    {
        bool canPickUp = Inventory.PLAYER_INVENTORY.CheckDuplicateItem(lampshade);

        if (!canPickUp)
        {
            Console.Clear();
            Console.WriteLine("Narrator:");
            Console.WriteLine("  The lamp is glowing faintly from the newly inserted bulb.");
            PressKeyToContinue.RunCommand();
            return;
        }

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Narrator:");
            Console.WriteLine("  As you inspect the lamp closer you notice that the lampshade has been");
            Console.WriteLine("  tampered with. You wonder why but let it go for now. Maybe there is a");
            Color.TextYellow("  bulb"); Console.WriteLine(" around to insert.");

            string userChoice = EnterInput.RunCommand();

            switch (userChoice)
            {
                case "bulb":
                    string toolIsInInventory = Inventory.PLAYER_INVENTORY.CheckToolInInventory(userChoice);

                    if (userChoice.Equals(toolIsInInventory))
                    {
                        Console.Clear();
                        DrawerInteraction.bulb.UseTool(); // You screw on the light bulb.
                        PlayAudio.Lightbuld();
                        PressKeyToContinue.RunCommand();
                        Console.Clear();
                        lampshade.PrintFindItem(); // The lampshade seems to have burn marks in the shape of a letter and number.
                        Inventory.PLAYER_INVENTORY.AddItem(lampshade); // You added {item.Name} to your inventory.
                        TableLocation.LampshadeAddedToInventory = true;
                        // Remove bulb from inventory?
                        return;
                    }
                    else
                    {
                        Console.Clear();
                        DrawerInteraction.bulb.MissingTool(); // You need a bulb
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

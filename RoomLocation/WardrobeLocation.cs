public class WardrobeLocation
{
    public static bool WardrobeUnlocked = false;
    public static bool ShoesAddedToInventory = false;
    public static bool DollAddedToInventory = false;
    public static void RunCommand()
    {
        while (!WardrobeUnlocked)
        {
            Console.Clear();

            Dialogue.PrintWardrobeDescription();

            string userChoice = EnterInput.RunCommand();

            switch (userChoice)
            {
                case "crowbar":
                    CrowbarInteraction.RunCommand();
                    break;

                case "inventory" or "inv":
                    CheckInventoryCommand.RunCommand();
                    break;

                case "help":
                    HelpCommand.RunCommand();
                    break;

                case "leave":
                    return;

                default:
                InvalidInput.RunCommand(userChoice);
                break;
            }
        }

        if (ShoesAddedToInventory && DollAddedToInventory)
        {
            Dialogue.PrintWardrobeEmptyDescription();
            PressKeyToContinue.RunCommand();
        }

        while (WardrobeUnlocked && (!ShoesAddedToInventory || !DollAddedToInventory))
        {
            Console.Clear();
            Dialogue.PrintWardrobeInsideDescription();

            string userChoice = EnterInput.RunCommand();

            switch (userChoice)
            {
                case "shoes":
                    Console.Clear();
                    ShoesInteraction.RunCommand();
                    break;

                case "doll":
                    Console.Clear();
                    DollInteraction.RunCommand();
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
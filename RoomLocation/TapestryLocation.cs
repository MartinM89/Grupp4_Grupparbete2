public class TapestryLocation
{
    public static bool TapestryRipped = false;
    public static bool TapestryRemoved = false;
    public static void RunCommand()
    {
        string userChoice;

        while (!TapestryRipped)
        {
            Console.Clear();
            Dialogue.PrintTapestryDescription();

            userChoice = EnterInput.RunCommand();

            switch (userChoice)
            {
                case "corner":
                    TapestryRipped = true;
                    Audio.PlaySound("./Audio/Audio/tapestry_rip.wav");
                    continue;

                case "inventory" or "inv":
                    CheckInventoryCommand.RunCommand();
                    break;

                case "leave":
                    Console.Clear();
                    return;

                case "help":
                    HelpCommand.RunCommand();
                    break;

                default:
                    InvalidInput.RunCommand(userChoice);
                    break;
            }
        }

        while (TapestryRipped && !TapestryRemoved)
        {
            Console.Clear();
            Dialogue.PrintTapestryRippedDescription();

            userChoice = EnterInput.RunCommand();

            switch (userChoice)
            {
                case "scraper":
                    RemoveTapestryInteraction.RunCommand(userChoice);
                    Audio.PlaySound("./Audio/Audio/tapestry_scraper.wav");
                    PressKeyToContinue.RunCommand();
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

        if (TapestryRemoved)
        {
            Console.Clear();
            TapestryInteraction.RunCommand();
            PressKeyToContinue.RunCommand();
        }
    }
}

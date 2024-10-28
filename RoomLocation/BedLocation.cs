public class BedLocation
{
    public static bool ScraperAddedToInventory = false;
    public static void RunCommand()
    {
        while (true)
        {
            Console.Clear();

            if (!ScraperAddedToInventory)
            {
                Dialogue.PrintBedDescription();
            }
            else
            {
                Dialogue.PrintNoScraperBedDescription();
            }
            

            string userChoice = EnterInput.RunCommand();

            switch (userChoice)
            {
                case "nap":
                    Console.Clear();
                    Dialogue.PrintBedSleepDescription();
                    PressKeyToContinue.RunCommand();

                    Console.Clear();
                    Dialogue.PrintBedWakeUpDescription();
                    PressKeyToContinue.RunCommand();

                    int minutes = 2;
                    // int seconds = 30;

                    KeypadInteraction.endTime += TimeSpan.FromMinutes(minutes);
                    // KeypadInteraction.endTime -= TimeSpan.FromSeconds(seconds);

                    Program.attemptsLeft += 1;
                    break;

                case "scraper":
                    ScraperInteraction.RunCommand();
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
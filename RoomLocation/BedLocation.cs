using System.Threading;

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

                    Thread audioThread = new Thread(PlayAudio.Dream);
                    Thread textThread = new Thread(Dialogue.PrintBedSleepDescription);

                    audioThread.Start();
                    textThread.Start();

                    Thread.Sleep(40620);

                    PressKeyToContinue.RunCommand();

                    Console.Clear();
                    Dialogue.PrintBedWakeUpDescription();
                    PressKeyToContinue.RunCommand();

                    int minutes = 2;
                    int seconds = 42;

                    KeypadInteraction.endTime += TimeSpan.FromMinutes(minutes);
                    KeypadInteraction.endTime -= TimeSpan.FromSeconds(seconds);

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

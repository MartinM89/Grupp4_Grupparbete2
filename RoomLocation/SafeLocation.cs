public class SafeLocation
{
    public static bool JournalAddedToInventory = false;
    public static void RunCommand()
    {
        Program.leaveLocation = true;

        while (Program.leaveLocation)
        {
            Console.Clear();

            if (!JournalAddedToInventory)
            {
                Dialogue.PrintSafeDescription();
            }
            else
            {
                Dialogue.PrintNoJournalSafeDescription();
            }


            string userChoice = EnterInput.RunCommand();

            switch (userChoice)
            {
                case "keypad":
                    Console.Clear();
                    KeypadInteraction.RunCommand();
                    break;

                case "key":
                    Console.Clear();
                    KeyInteraction.InsertKey(userChoice);
                    break;

                case "journal":
                    Console.Clear();
                    JournalInteraction.RunCommand();
                    break;

                case "inventory" or "inv":
                    CheckInventoryCommand.RunCommand();
                    break;

                case "help":
                    HelpCommand.RunCommand();
                    break;

                case "leave" or "":
                    Program.leaveLocation = false;
                    break;

                default:
                    InvalidInput.RunCommand(userChoice);
                    break;
            }
        }
    }
}

public class RugLocation
{
    public static bool NoteAddedToInventory = false;

    public static void RunCommand()
    {
        if (NoteAddedToInventory)
        {
            Console.Clear();
            Dialogue.PrintRugEmptyDescription();
            ColorManager.SetInvestigated("rug");
            PressKeyToContinue.RunCommand();
        }

        while (!NoteAddedToInventory)
        {
            Console.Clear();
            Dialogue.PrintRugDescription();
            string userChoice = EnterInput.RunCommand();

            switch (userChoice)
            {
                case "knife":
                    NoteInteraction.RunCommand(userChoice);
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

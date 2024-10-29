public class PaintingLocation
{
    public static bool KeyAddedToInventory = false;
    public static void RunCommand()
    {
        // Console.Clear();
        // Dialogue.PrintPaintingDescription();
        // PressKeyToContinue.RunCommand();

        if (KeyAddedToInventory)
        {
            Console.Clear();
            // Dialogue.PrintPaintingEmptyDescription();
            Console.WriteLine("Narrator:");
            Console.WriteLine("  The painting frame is a little loose, you can't seem to put it back");
            Console.WriteLine("  the way it used to be.");
            PressKeyToContinue.RunCommand();
        }

        while (!KeyAddedToInventory)
        {
            Console.Clear();
            Dialogue.PrintPaintingDescription();
            string userChoice = EnterInput.RunCommand();

            switch (userChoice)
            {
                case "key":
                    KeyInteraction.RunCommand();
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

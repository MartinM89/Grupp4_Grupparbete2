public class PaintingLocation
{
    public static bool KeyAddedToInventory = false;

    public static void RunCommand()
    {
        if (KeyAddedToInventory)
        {
            Console.Clear();
            Dialogue.PrintPaintingEmptyDescription();
            ColorManager.SetInvestigated("painting");
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

class WindowLocation
{
    public static bool KnifeAddedToInventory = false;

    public static void RunCommand()
    {
        if (KnifeAddedToInventory)
        {
            Console.Clear();
            Dialogue.PrintWindowEmptyDescription();
            PressKeyToContinue.RunCommand();
        }

        while (!KnifeAddedToInventory)
        {
            Console.Clear();
            Dialogue.PrintWindowDescription();
            string userChoice = EnterInput.RunCommand();

            switch (userChoice)
            {
                case "knife":
                    KnifeInteraction.RunCommand();
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
public class NighttableInteraction
{
public static void RunCommand()
    {
        while (true)
        {
            Console.Clear();

            Dialogue.PrintTableDescription();

            string userChoice = EnterInput.RunCommand();

            switch (userChoice)
            {
                case "lamp":
                    Console.Clear();
                    LampInteraction.RunCommand();
                    break;

                case "drawer":
                    Console.Clear();
                    DrawerInteraction.RunCommand();
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


// Ta bort
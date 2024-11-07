public class KeyInteraction
{
    public static Key key = new Key();

    public static void RunCommand()
    {
        bool canPickUp = Inventory.PLAYER_INVENTORY.CheckDuplicateTool(key);

        if (canPickUp)
        {
            Console.Clear();
            key.PrintFindItem();
            AudioPlayer.PlaySound("./Audio/Sounds/find_secret.wav");
            Inventory.PLAYER_INVENTORY.AddTool(key);
            PaintingLocation.KeyAddedToInventory = true;
        }
    }

    public static void InsertKey(string userChoice)
    {
        string toolIsInInventory = Inventory.PLAYER_INVENTORY.CheckToolInInventory(userChoice);

        if (!userChoice.Equals(toolIsInInventory))
        {
            Console.Clear();
            key.MissingTool();
            PressKeyToContinue.RunCommand();
            return;
        }

        Console.Clear();
        key.UseTool();
        Highscore.AddAndPrintList();
        EndCredits.RunCommand();
        return;
    }
}

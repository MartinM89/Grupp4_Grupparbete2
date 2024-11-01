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
            Audio.PlaySound("./Audio/Audio/find_secret.wav");
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
        }

        Console.Clear();
        key.UseTool();
        Highscore.Execute();
        EndCredits.RunCommand();
        return;
    }
}

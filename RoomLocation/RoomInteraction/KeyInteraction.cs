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
            Inventory.PLAYER_INVENTORY.AddTool(key);
            PaintingLocation.KeyAddedToInventory = true;
        }
    }
}

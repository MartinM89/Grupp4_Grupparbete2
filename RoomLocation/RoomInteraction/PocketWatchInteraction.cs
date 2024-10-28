public class PocketWatchInteraction
{
    public static PocketWatch watch = new PocketWatch();
    public static void RunCommand()
    {
        Console.Clear();
        bool canPickUp = Inventory.PLAYER_INVENTORY.CheckDuplicateItem(watch);

        if (canPickUp)
        {
            watch.PrintFindItem();
            Inventory.PLAYER_INVENTORY.AddItem(watch);
            CoatLocation.WatchAddedToInventory = true;
        }
    }
}
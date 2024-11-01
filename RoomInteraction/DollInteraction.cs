public class DollInteraction
{
    public static Doll doll = new Doll();
    public static void RunCommand()
    {
        bool canPickUp = Inventory.PLAYER_INVENTORY.CheckDuplicateItem(doll);

        if (canPickUp)
        {
            doll.PrintFindItem();
            Inventory.PLAYER_INVENTORY.AddItem(doll);
            WardrobeLocation.DollAddedToInventory = true;
        }
    }
}

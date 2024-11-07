public class KnifeInteraction
{
    public static Knife knife = new Knife();

    public static void RunCommand()
    {
        bool canPickUp = Inventory.PLAYER_INVENTORY.CheckDuplicateTool(knife);

        if (canPickUp)
        {
            Console.Clear();
            knife.PrintFindItem();
            Inventory.PLAYER_INVENTORY.AddTool(knife);
            WindowLocation.KnifeAddedToInventory = true;
        }
    }
}

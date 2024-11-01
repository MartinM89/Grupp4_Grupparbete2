public class CheckInventoryCommand
{
    public static void RunCommand()
    {
        Console.Clear();
        Inventory.PLAYER_INVENTORY.PrintInventory();

        PressKeyToContinue.RunCommand();
    }
}

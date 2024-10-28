public class CrowbarLocation
{
    public static Crowbar crowbar = new Crowbar();
    public static void RunCommand()
    {
        Console.Clear();

        bool canPickUp = Inventory.PLAYER_INVENTORY.CheckDuplicateTool(crowbar);

        if (canPickUp)
        {
            crowbar.PrintFindItem();
            Inventory.PLAYER_INVENTORY.AddTool(crowbar);
        }
        else
        {
            crowbar.AlreadyInInventory();
            PressKeyToContinue.RunCommand();
        }
    }
}
public class CrowbarInteraction
{
    public static void RunCommand()
    {
        string toolIsInInventory = Inventory.PLAYER_INVENTORY.CheckToolInInventory("crowbar");

        if ("crowbar".Equals(toolIsInInventory))
        {
            Console.Clear();
            WardrobeLocation.WardrobeUnlocked = true;
            CrowbarLocation.crowbar.UseTool();
            AudioPlayer.PlaySound("./Audio/Audio/wardrobe_crowbar_creak.wav");
            PressKeyToContinue.RunCommand();
            return;
        }
            Console.Clear();
            CrowbarLocation.crowbar.MissingTool();
            PressKeyToContinue.RunCommand();
    }
}

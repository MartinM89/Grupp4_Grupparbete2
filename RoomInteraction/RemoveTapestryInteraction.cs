public class RemoveTapestryInteraction
{
    public static void RunCommand(string userChoice)
    {
        string toolIsInInventory = Inventory.PLAYER_INVENTORY.CheckToolInInventory(userChoice);

        if (userChoice.Equals(toolIsInInventory))
        {
            Console.Clear();
            Dialogue.PrintTapestryRemovedDescription();
            TapestryLocation.TapestryRemoved = true;
        }
        else
        {
            Console.Clear();
            ScraperInteraction.scraper.MissingTool();
        }
    }
}

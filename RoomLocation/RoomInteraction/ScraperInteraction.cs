public class ScraperInteraction
{
    public static Scraper scraper = new Scraper();
    public static void RunCommand()
    {
        Console.Clear();
        bool canPickUp = Inventory.PLAYER_INVENTORY.CheckDuplicateTool(scraper);

        if (canPickUp)
        {
            scraper.PrintFindItem();
            Inventory.PLAYER_INVENTORY.AddTool(scraper);
            BedLocation.ScraperAddedToInventory = true;
        }
    }
}

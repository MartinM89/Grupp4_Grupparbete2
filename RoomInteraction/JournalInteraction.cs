public class JournalInteraction
{
    public static Journal journal = new Journal();
    public static void RunCommand()
    {
        bool canPickUp = Inventory.PLAYER_INVENTORY.CheckDuplicateItem(journal);

        if (canPickUp)
        {
            journal.PrintFindItem();
            AudioPlayer.PlaySound("./Audio/Audio/journal_read.wav");
            Inventory.PLAYER_INVENTORY.AddItem(journal);
            SafeLocation.JournalAddedToInventory = true;
        }
    }
}

public class BusinessCardInteraction
{
    public static BusinessCard card = new BusinessCard();

    public static void RunCommand()
    {
        Console.Clear();
        bool canPickUp = Inventory.PLAYER_INVENTORY.CheckDuplicateItem(card);

        if (!canPickUp)
        {
            Dialogue.PrintEmptyShoesDescription();
            PressKeyToContinue.RunCommand();
        }

        if (canPickUp)
        {
            card.PrintFindItem();
            Inventory.PLAYER_INVENTORY.AddItem(card);
            CoatLocation.CardAddedToInventory = true;
        }
    }
}

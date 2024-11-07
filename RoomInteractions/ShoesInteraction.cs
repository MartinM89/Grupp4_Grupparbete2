public class ShoesInteraction
{
    public static Shoes shoe = new Shoes();

    public static void RunCommand()
    {
        bool canPickUp = Inventory.PLAYER_INVENTORY.CheckDuplicateItem(shoe);

        if (!canPickUp)
        {
            Dialogue.PrintEmptyShoesDescription();
            PressKeyToContinue.RunCommand();
        }

        if (canPickUp)
        {
            shoe.PrintFindItem();
            Inventory.PLAYER_INVENTORY.AddItem(shoe);
            WardrobeLocation.ShoesAddedToInventory = true;
        }
    }
}

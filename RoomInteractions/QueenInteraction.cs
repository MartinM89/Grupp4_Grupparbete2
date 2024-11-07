public class QueenInteraction
{
    public static QueenPiece queen = new QueenPiece();

    public static void RunCommand()
    {
        bool canPickUp = Inventory.PLAYER_INVENTORY.CheckDuplicateItem(queen);

        if (canPickUp)
        {
            Console.Clear();
            queen.PrintFindItem();
            Inventory.PLAYER_INVENTORY.AddItem(queen);
            ChessboardLocation.QueenAddedToInventory = true;
        }
    }
}

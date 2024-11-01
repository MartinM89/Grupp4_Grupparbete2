public class WalletInteraction
{
    public static Wallet wallet = new Wallet();
    public static void RunCommand()
    {
        bool canPickUp = Inventory.PLAYER_INVENTORY.CheckDuplicateItem(wallet);

        if (canPickUp)
        {
            Console.Clear();
            wallet.PrintFindItem();
            PlayAudio.Mirror();
            Inventory.PLAYER_INVENTORY.AddItem(wallet);
            MirrorLocation.WalletAddedToInventory = true;
        }
    }
}

public class NoteInteraction
{
    public static Note note = new Note();
    public static void RunCommand(string userChoice)
    {
        string toolIsInInventory = Inventory.PLAYER_INVENTORY.CheckToolInInventory(userChoice);

        // Console.WriteLine($"Test Knife Bool. User Choice: {userChoice} | Inventory: {toolIsInInventory}"); // debugging
        // PressKeyToContinue.RunCommand(); // debugging

        if (userChoice.Equals(toolIsInInventory))
        {
            Console.Clear();
            KnifeInteraction.knife.UseTool();
            Audio.PlaySound("./Audio/Audio/rug_cut.wav");

            bool canPickUp = Inventory.PLAYER_INVENTORY.CheckDuplicateItem(note);

            if (canPickUp)
            {
                Inventory.PLAYER_INVENTORY.AddItem(note);
            }

            RugLocation.NoteAddedToInventory = true;
        }
        else
        {
            Console.Clear();
            KnifeInteraction.knife.MissingTool();
            PressKeyToContinue.RunCommand();
        }
    }
}

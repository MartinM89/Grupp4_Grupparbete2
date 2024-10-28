public class CheckInventoryCommand
{
    public static void RunCommand()
    {
        Console.Clear();
        Inventory.PLAYER_INVENTORY.PrintInventory();

        PressKeyToContinue.RunCommand();
    }
}

// Inventory List:
// Item 1
// Item 2
// Item 3

// Switch (userChoice)

// Item 1
// If (item = exists)
// Print item 1 description
// break;

// Item 2
// If (item = exists)
// Print item 2 description
// break;

// Item 3
// If (item = exists)
// Print item 3 description
// break;

// Leave
// return;

// default
// Invalid Input
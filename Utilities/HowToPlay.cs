public class HowToPlay
{
    public static void RunCommand()
    {
        Console.WriteLine("How to play:\n");

        Color.TextCyan("Moving to Locations:"); Console.Write("\n  Any word in cyan text is a keyword for a location you can move to.\n");
        Console.WriteLine("  Type the word to travel to that location.\n");

        Color.TextGreen("Picking Up Items:"); Console.Write("\n  Any word in green text represents an item that can be picked up.\n");
        Console.WriteLine("  Type the keyword to add it to your inventory.\n");

        Color.TextYellow("Picking Up Tools:"); Console.Write("\n  Any word in yellow text represents a tool that can be picked up.\n");
        Console.WriteLine("  Type the keyword to add it to your inventory or use it.\n");

        Color.TextRed("Completed locations:"); Console.WriteLine("\n  Any location in red text represents a location that is fully\n  investigated.\n");

        Color.TextBlue("Leaving a Location:"); Console.WriteLine("\n  If you want to leave a location, simply type 'leave.'\n");

        Color.TextBlue("Checking Your Inventory:"); Console.WriteLine("\n  You can type 'inventory' or 'inv' at any time to check what");
        Console.WriteLine("  you're carrying.");
    }
}

public class PaintingLocation
{
    public static void RunCommand()
    {
        Console.Clear();
        Dialogue.PrintPaintingDescription();
        PressKeyToContinue.RunCommand();
    }
}
public class ExitCommand
{
    public static bool RunCommand()
    {
        Program.leaveLocation = false;
        Program.running = false;
        return Program.running;
    }
}

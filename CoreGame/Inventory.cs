
public class Inventory
{
    public static Letter letter = new Letter();
    private List<Item> items = new List<Item>() { letter };
    private List<Tool> tools = new List<Tool>();
    public static Inventory PLAYER_INVENTORY = new Inventory();

    public void AddItem(Item item)
    {
        items.Add(item);
        Color.TextGreen($"You add {item.Name} to your inventory.\n");
        PressKeyToContinue.RunCommand();
    }

    public void AddTool(Tool tool)
    {
        tools.Add(tool);
        Color.TextGreen($"You add {tool.Name} to your inventory.\n");
        PressKeyToContinue.RunCommand();
    }

    public bool CheckDuplicateItem(Item item)
    {
        foreach (Item i in items)
        {
            if (item.Equals(i))
            {
                return false;
            }
        }

        return true;
    }

    public bool CheckDuplicateTool(Tool tool)
    {
        foreach (Tool t in tools)
        {
            if (tool.Equals(t))
            {
                return false;
            }
        }

        return true;
    }

    public string CheckToolInInventory(string tool)
    {

        foreach (Tool t in tools)
        {
            if (tool.Equals(t.Name?.ToLower()))
            {
                return tool;
            }
        }
        return null!;
    }

    public void PrintInventory()
    {
        Console.WriteLine("Items:");
        foreach (Item item in items)
        {
            Console.WriteLine($"{item.Name}: {item.LetterNumber}");
        }
        Console.WriteLine("\nTools:");
        foreach (Tool tool in tools)
        {
            if (tools.Count.Equals(0))
            {
                Console.WriteLine("You have no tools.");
            }
            Console.WriteLine($"{tool.Name}: {tool.Description}");
        }
    }
}

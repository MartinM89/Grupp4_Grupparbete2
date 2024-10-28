public abstract class Object
{
    public string? Name { get; private set; }
    public string? Description { get; private set; }
    public Object(string name, string description)
    {
        this.Name = name;
        this.Description = description;
    }

    public abstract void PrintFindItem();
}

#region Items
public abstract class Item : Object
{
    public string? LetterNumber { get; private set; }

    public Item(string name, string description, string letterNumber) : base(name, description)
    {
        this.LetterNumber = letterNumber;
    }
}

public class Letter : Item
{
    public Letter() : base("Letter", "Description", "J-8")
    {
    }

    public override void PrintFindItem()
    {
        string lineOne = "Dear Reader,\n";
        string lineTwo = "If you're holding this, it means you're curious. Good. I've left something\n";
        string lineThree = "for those with the patience and sharp eyes to find it. There's a safe in\n";
        string lineFour = "this room, and inside it, well... that's for you to discover. The code is\n";
        string lineFive = "hidden among the things I've left behind. You'll have to piece it together.\n\n";

        string lineSix = "I always believed that the best rewards come from a little hard work.\n";
        string lineSeven = "Take your time, look closely, and don't rush. If you've made it this far,\n";
        string lineEight = "you're already on the right track.\n\n";

        string lineNine = "Best of luck,\n";
        string lineTen = "~Henry\n";

        PrintByCharacter.RunCommand(lineOne); // Dear Reader,
        PrintByCharacter.RunCommand(lineTwo); // If you're holding this, it means you're curious. Good. I've left something
        PrintByCharacter.RunCommand(lineThree); // for those with the patience and sharp eyes to find it. There's a safe in
        PrintByCharacter.RunCommand(lineFour); // this room, and inside it, well... that's for you to discover. The code is
        PrintByCharacter.RunCommand(lineFive); // hidden among the things I've left behind. You'll have to piece it together.

        PrintByCharacter.RunCommand(lineSix); // I always believed that the best rewards come from a little hard work.
        PrintByCharacter.RunCommand(lineSeven); // Take your time, look closely, and don't rush. If you've made it this far,
        PrintByCharacter.RunCommand(lineEight); // you're already on the right track.

        PrintByCharacter.RunCommand(lineNine); // Best of luck,
        PrintByCharacter.RunCommand(lineTen); // ~Henry

    }
}

public class Journal : Item
{
    public Journal() : base("Journal", "Description", "H-5")
    {
    }

    public override void PrintFindItem()
    {
        Console.WriteLine("Narrator:");
        Console.WriteLine("  A weathered journal, its pages yellowed with age. Inside, the old man's");
        Console.WriteLine("  tales about life and cryptic notes hint at something deeper. Many pages");
        Console.WriteLine("  are torn out.\n");
    }
}

public class Note : Item
{
    public Note() : base("Note", "Description", "F-2")
    {
    }

    public override void PrintFindItem()
    {
        Console.WriteLine("Narrator:");
        Console.WriteLine("  A neatly folded paper simply showing you the text 'F-2'\n");
    }
}

public class Wallet : Item
{
    public Wallet() : base("Wallet", "Description", "A-9")
    {
    }

    public override void PrintFindItem()
    {
        Console.WriteLine("Narrator:");
        Console.WriteLine("  An old fanshioned leather wallet, its leather cracked.\n");
    }
}

public class BusinessCard : Item
{
    public BusinessCard() : base("Business card", "Description", "C-6")
    {
    }

    public override void PrintFindItem()
    {
        Console.WriteLine("Narrator:");
        Console.WriteLine("  A yellowed card with the old man's face faintly visible. Only a “C” and ");
        Console.WriteLine("  a “6” can be made out from his name and number.\n");
    }
}

public class PocketWatch : Item
{
    public PocketWatch() : base("Pocket watch", "Description", "B-4")
    {
    }

    public override void PrintFindItem()
    {
        Console.WriteLine("Narrator:");
        Console.WriteLine("  An elegant, silver watch that has stopped ticking. Its chain is twisted,");
        Console.WriteLine("  and the hands are frozen at an odd time.\n");
    }
}

public class Shoes : Item
{
    public Shoes() : base("Shoes", "Description", "D-1")
    {
    }

    public override void PrintFindItem()
    {
        Console.WriteLine("Narrator:");
        Console.WriteLine("  A pair of worn leather shoes, scuffed from years of use. There's");
        Console.WriteLine("  something off about their weight.\n");
    }
}

public class Doll : Item
{
    public Doll() : base("Doll", "Description", "E-7")
    {
    }

    public override void PrintFindItem()
    {
        Console.WriteLine("Narrator:");
        Console.WriteLine("  A small, porcelain doll with chipped paint and a cracked face. Its");
        Console.WriteLine("  empty eyes seem to follow you.\n");
    }
}

public class QueenPiece : Item
{
    public QueenPiece() : base("Queen", "Description", "I-3")
    {
    }

    public override void PrintFindItem()
    {
        Console.WriteLine("Narrator:");
        Console.WriteLine("  You pick up the queen piece positioned on I-3. It's a tad sticky.\n"); // Did you notice that I-3 is not a real position in chess?
    }
}

public class Lampshade : Item
{
    public Lampshade() : base("Lampshade", "Description", "G-0")
    {
    }

    public override void PrintFindItem()
    {
        Console.WriteLine("Narrator:");
        Console.WriteLine("  The lampshade seems to have burn marks in the shape of a letter and");
        Console.WriteLine("  number.\n");
    }
}
#endregion

#region Tools
public abstract class Tool : Object
{
    public Tool(string name, string description) : base(name, description)
    {
    }
    public virtual void UseTool()
    {
        Console.WriteLine("Narrator:");
        Console.WriteLine($"  You use the {this.Name}.");
    }
    public virtual void MissingTool()
    {
        Console.WriteLine("Narrator:");
        Console.WriteLine($"  You need a {this.Name}.");
    }

    public virtual void AlreadyInInventory()
    {
        Console.WriteLine("Narrator:");
        Console.WriteLine($"  You already have the {this.Name}");
    }
}

public class Knife : Tool
{
    public Knife() : base("Knife", "A sharp, small knife with a wooden handle.")
    {
    }

    public override void UseTool()
    {
        Console.WriteLine("Narrator:");
        Console.WriteLine("  The blade easily cuts through fabric of the rug. You find a note");
        Console.WriteLine("  hidden underneath.\n");
    }

    public override void MissingTool()
    {
        Console.WriteLine("Narrator:");
        Console.Write("  You need a "); Color.TextYellow("knife"); Console.WriteLine(" to cut through the rug.");
    }

    public override void PrintFindItem()
    {
        Console.WriteLine("Narrator:");
        Console.WriteLine("  You find a an old rusty knife with a chipped wooden handle.\n");
    }
}

public class Crowbar : Tool
{
    public Crowbar() : base("Crowbar", "It feels like it could pry open just about anything.")
    {
    }

    public override void UseTool()
    {
        Console.WriteLine("Narrator:");
        Console.WriteLine("  You wedge the crowbar and force the wardrobe open with a creak.");
    }

    public override void MissingTool()
    {
        Console.WriteLine("Narrator:");
        Console.Write("  The wardrobe is stuck, you need a "); Color.TextYellow("crowbar"); Console.WriteLine(" to open it!");
    }

    public override void PrintFindItem()
    {
        Console.WriteLine("Narrator:");
        Console.WriteLine("  A solid metal bar. It feels like it could pry open just about anything.\n");
    }

    public override void AlreadyInInventory()
    {
        Console.WriteLine("Narrator:");
        Console.WriteLine("  As you step forward, you notice only an empty space where something");
        Console.WriteLine("  once rested.");
    }
}
public class Scraper : Tool
{
    public Scraper() : base("Scraper", "A rusty, flat tool, perfect for scraping away layers of dirt or grime.")
    {
    }

    public override void UseTool()
    {
        Console.WriteLine("Narrator:");
        Console.WriteLine("  You carefully scrape away the dust and grime, revealing a secret.");
    }

    public override void MissingTool()
    {
        Console.WriteLine("Narrator:");
        Console.Write("  The tapestry is still ripped, you need a "); Color.TextYellow("scraper"); Console.WriteLine(" to remove it.");
    }

    public override void PrintFindItem()
    {
        Console.WriteLine("Narrator:");
        Console.WriteLine("  A rusty, flat tool, perfect for scraping away layers of dirt or grime.\n");
    }
}

public class Bulb : Tool
{
    public Bulb() : base("Bulb", "A small, dusty light bulb. When held, it feels unusually cold.")
    {
    }
    public override void UseTool()
    {
        Console.WriteLine("Narrator:");
        Console.WriteLine("  You screw on the light bulb, shedding light around the room.");
    }

    public override void MissingTool()
    {
        Console.WriteLine("Narrator:");
        Console.WriteLine("  You need to find a light bulb, it must be one nearby.");
    }

    public override void PrintFindItem()
    {
        Console.WriteLine("Narrator:");
        Console.WriteLine("  A small, dusty light bulb. When held, it feels unusually cold.\n");
    }
}
#endregion

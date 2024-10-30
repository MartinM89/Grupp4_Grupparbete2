class Dialogue
{
    #region MAIN DIALOGUE
    public static void PrintRoomDescription() // 73
    {
        Console.WriteLine("Narrator:");
        Console.WriteLine("  As you step into the dimly lit room, a faint musty smell fills the air.");
        Console.Write("  Your feet press into a worn "); Color.TextCyan("rug"); Console.WriteLine(" as you step forward, eyes catching ");
        Console.Write("  the glint of a "); Color.TextYellow("crowbar"); Console.Write(" leaning against an aged "); Color.TextCyan("chessboard"); Console.WriteLine(". The dusty");
        Color.TextCyan("  mirror"); Console.Write(" across the room reflects the crooked "); Color.TextCyan("painting"); Console.WriteLine(" on the wall.");
        Console.Write("  Near a clouded "); Color.TextCyan("window"); Console.Write(", a tattered "); Color.TextCyan("coat"); Console.WriteLine(" hangs forgotten. In the corner,");
        Console.Write("  a "); Color.TextCyan("safe"); Console.Write(" is nearly hidden beneath layers of grime. A weathered "); Color.TextCyan("tapestry\n");
        Console.Write("  drapes loosely on the wall, while a creaking "); Color.TextCyan("wardrobe"); Console.WriteLine(" stands beside the");
        Color.TextCyan("  bed"); Console.Write(" and cluttered "); Color.TextCyan("table"); Console.WriteLine(".");
    }
    #endregion

    #region RUG DIALOGUE
    public static void PrintRugDescription()
    {
        Console.WriteLine("Narrator:");
        Console.WriteLine("  You step onto a faded rug, firmly glued to the floor. The center is");
        Console.Write("  threadbare, and cutting around it with a "); Color.TextYellow("knife"); Console.Write(" might help lift it.\n");
    }

    public static void PrintRugEmptyDescription()
    {
        Console.WriteLine("Narrator:");
        Console.WriteLine("  The rug has a hole at its center, there is no longer a note hidden here.");
    }
    #endregion

    #region CHESSBOARD DIALOGUE
    public static void PrintChessboardDescription()
    {
        Console.WriteLine("Narrator:");
        Console.Write("  The chessboard lies bare, every piece missing except for the "); Color.TextGreen("queen"); Console.WriteLine(",");
        Console.WriteLine("who stands alone on a white square");
    }

    public static void PrintChessboardEmptyDescription()
    {
        Console.WriteLine("Narrator:");
        Console.WriteLine("  The chessboard is empty. Only a faint outline remains where the queen");
        Console.WriteLine("  once stood—a clean square amid the thin layer of dust");
    }
    #endregion

    #region PAINTING DIALOGUE
    public static void PrintPaintingDescription()
    {
        Console.WriteLine("Narrator:");
        Console.WriteLine("  A large, dust-covered canvas hangs crooked on the wall. The paint is ");
        Console.WriteLine("  cracked and peeling. Faint outlines of a landscape can be seen through");
        Console.WriteLine("  the decay, but the details are too worn to fully make out. You can see");
        Console.WriteLine("  something through the cracks.");
    }

    public static void PrintPaintingEmptyDescription()
    {
        Console.WriteLine("Narrator:");
        Console.WriteLine("  The painting frame is a little loose, you can't seem to put it back");
        Console.WriteLine("  the way it used to be.");
    }
    #endregion

    #region MIRROR DIALOGUE
    public static void PrintMirrorDescription()
    {
        Console.WriteLine("Narrator:");
        Console.WriteLine("  An old mirror with a cloudy surface, barely reflecting anything. As you");
        Console.WriteLine("  peer into it, the faint outline of an old man is visibile. He reaches");
        Console.WriteLine("  up and shifts the mirror to the left. A compartment is revealed behind,");
        Console.Write("  with a "); Color.TextGreen("wallet"); Console.Write(" resting inside.\n");
    }

    public static void PrintMirrorEmptyDescription()
    {
        Console.WriteLine("Narrator:");
        Console.WriteLine("  The mirror's hidden compartment lies empty now, the old man's presence");
        Console.WriteLine("  faded from view.");
    }
    #endregion

    #region WINDOW DIALOGUE
    public static void PrintWindowDescription()
    {
        Console.WriteLine("Narrator:");
        Console.WriteLine("  You walk towards the window, a sudden chill seeps through the window");
        Console.WriteLine("  frame, making you shiver. Looking outside, you see the cold autumn");
        Console.WriteLine("  night settling in, the wind stirring the bare branches of the trees.");
        Console.Write("  Your eyes drift towards the windowstool, where a rusty "); Color.TextYellow("knife"); Console.WriteLine(" lies");
        Console.WriteLine("  catching the faint glow of the moonlight.");
    }

    public static void PrintWindowEmptyDescription()
    {
        Console.WriteLine("Narrator:");
        Console.WriteLine("  The cold air still seeps through the window frame, you shouldn't");
        Console.WriteLine("  stay here or you will catch a cold.");
    }
    #endregion

    #region COAT DIALOGUE
    public static void PrintCoatDescription()
    {
        Console.WriteLine("Narrator:");
        Console.WriteLine("  An old, forgotten coat hangs by the door, layers of dust has settled on");
        Console.WriteLine("  its worn shoulders. In the pockets, you can feel the outline of a pocket");
        Color.TextGreen("  watch"); Console.Write(" and a crumpled business "); Color.TextGreen("card"); Console.WriteLine(".");
    }

    public static void PrintEmptyCoatDescription()
    {
        Console.WriteLine("Narrator:");
        Console.WriteLine("  The coat still hangs barely touched, but its pockets are now empty, the");
        Console.WriteLine("  fabric remains still, gathering dust in the quiet room.");
    }
    #endregion

    #region TABLE DIALOGUE
    public static void PrintTableDescription()
    {
        Console.WriteLine("Narrator:");
        Console.Write("  A simple, wooden table stands beside the bed. On it, an old "); Color.TextCyan("lamp"); Console.WriteLine(" missing");
        Console.Write("  its bulb, sitting slightly tilted. The table has a single "); Color.TextCyan("drawer"); Console.WriteLine(", its");
        Console.WriteLine("  handle a little loose, and next to the lamp lies a small matchbox its");
        Console.WriteLine("  cover, faded. A scratched coin rests nearby.");
    }

    public static void PrintTableCompleteDescription()
    {
        Console.WriteLine("Narrator:");
        Console.WriteLine("  The table looks more complete now, the lamp glowing softly after a new");
        Console.WriteLine("  bulb was added.");
    }

    public static void PrintDrawerDescription()
    {
        Console.WriteLine("Narrator:");
        Console.WriteLine("  The drawer slides open to reveal a scattered collection of items. A");
        Console.Write("  light "); Color.TextYellow("bulb"); Console.WriteLine(" sits among a tangle of string, a few bent paperclips, and");
        Console.WriteLine("  an old photograph, its edges curling. You get the impression that");
        Console.WriteLine("  the drawer has been untouched for years, holding small fragments of");
        Console.WriteLine("  someone's life");
    }

    public static void PrintEmptyDrawerDescription()
    {
        Console.WriteLine("Narrator:");
        Console.WriteLine("  With the bulb removed, the drawer holds only a few random items—bits");
        Console.WriteLine("  of string, paperclips, and a photograph. Nothing of particular value");
        Console.WriteLine("  remains, just the quiet clutter of forgotten things.");
    }
    #endregion

    // animate text for dream
    #region BED DIALOGUE
    public static void PrintBedDescription()
    {
        Console.WriteLine("Narrator:");
        Console.WriteLine("  An old bed sits in the corner, its worn frame surprisingly still");
        Console.Write("  inviting. If you're feeling tired, you could take a "); Color.TextCyan("nap"); Console.WriteLine(". Beneath the");
        Console.Write("  bed, partially hidden in the dim light, you notice a "); Color.TextYellow("scraper"); Console.WriteLine(" lying");
        Console.WriteLine("  on the floor.");
    }

    public static void PrintNoScraperBedDescription()
    {
        Console.WriteLine("Narrator:");
        Console.WriteLine("  An old bed sits in the corner, its worn frame surprisingly still");
        Console.Write("  inviting. If you're feeling tired, you could take a "); Color.TextCyan("nap"); Console.WriteLine(".");
    }

    public static void PrintBedSleepDescription()
    {
        Console.WriteLine("Narrator:");
        Console.WriteLine("  As you close your eyes, sleep quickly takes over. In the darkness, a");
        Console.WriteLine("  faint image starts to form, pulling you deeper into a dream.\n");

        Console.WriteLine("  You see the old man, his back hunched as he works with steady hands,");
        Console.WriteLine("  carefully hanging the tapestry that now adorns the walls. His face is");
        Console.WriteLine("  tired and fatigued, but his expression is focused. He steps back,");
        Console.WriteLine("  inspecting his work. He mutters to himself, something about \"hiding");
        Console.WriteLine("  things where only the patient will find them.\"\n");

        Console.WriteLine("  The room feels warmer in the dream, the old man wiping sweat from his");
        Console.WriteLine("  brow. He reaches into his coat pocket, pulling out a worn scraper.");
        Console.WriteLine("  Slowly, he begins to smooth the edges of the tapestry.\n");

        Console.WriteLine("  Then, the scene fades. His figure blurs into shadow, leaving only the");
        Console.WriteLine("  image of the tapestry swaying slightly on the walls.");
    }

    public static void PrintBedWakeUpDescription()
    {
        Console.WriteLine("Narrator:");
        Console.WriteLine("  As you wake up, it feels like something has subtly shifted. You can't");
        Console.WriteLine("  explain it, but you have the distinct feeling that you're better of.");
    }
    #endregion

    #region WARDROBE DIALOGUE
    public static void PrintWardrobeDescription()
    {
        Console.WriteLine("Narrator:");
        Console.WriteLine("  You step toward the old wooden wardrobe, its dark, heavy frame filling");
        Console.WriteLine("  the corner of the room. The doors are stuck tight, unmoved for a long");
        Console.Write("  time. A "); Color.TextYellow("crowbar"); Console.Write(" would probably help pry them open.\n");
    }

    public static void PrintWardrobeEmptyDescription()
    {
        Console.WriteLine("Narrator:");
        Console.WriteLine("  The wardrobe now stands open and empty, its bare interior holding only");
        Console.WriteLine("  the scent of aged wood.");
    }

    public static void PrintWardrobeInsideDescription()
    {
        Console.WriteLine("Narrator:");
        Console.WriteLine("  The doors stand open, revealing a few forgotten things inside. A pair");
        Console.Write("  of "); Color.TextGreen("shoes"); Console.Write(" sits neatly on the bottom, while a "); Color.TextGreen("doll"); Console.WriteLine(" leans against the back");
        Console.WriteLine("  wall, its glassy eyes staring ahead, untouched for years");
    }
    #endregion

    #region TAPESTRY DIALOGUE
    public static void PrintTapestryDescription()
    {
        Console.WriteLine("Narrator:");
        Console.Write("  A faded, cloth tapestry hangs on the wall, its colors dulled. One "); Color.TextYellow("corner\n");
        Console.WriteLine("  has come loose, dangling slightly.");
    }

    public static void PrintTapestryRippedDescription()
    {
        Console.WriteLine("Narrator:");
        Console.Write("  The tapestry is partially torn. You'll need a "); Color.TextYellow("scraper"); Console.WriteLine(" to remove it");
        Console.WriteLine("  completely and see what lies behind.");
    }

    public static void PrintTapestryRemovedDescription()
    {
        Console.WriteLine("Narrator:");
        Console.WriteLine("  With effort, you pull the tapestry from the wall, letting it fall away");
        Console.WriteLine("  to reveal what is concealed.");
    }

    public static void PrintTapestryCodeDescription()
    {
        Console.WriteLine("Narrator:");
        Console.WriteLine("  Behind the tapestry, faint but clear, you spot four letters scrawled on");
        Console.WriteLine("  the wall:\n");
    }
    #endregion

    #region SAFE DIALOGUE
    public static void PrintSafeDescription()
    {
        Console.WriteLine("Narrator:");
        Console.Write("  You step closer to the old safe, its metal cold and heavy. A "); Color.TextYellow("keypad\n");
        Console.WriteLine("  waits for the right code to unlock it. Below it is a keyhole centered.");
        Console.Write("  Resting on top is a worn "); Color.TextGreen("journal"); Console.WriteLine(" its cover frayed and pages slightly");
        Console.WriteLine("  yellowed.");
    }

    public static void PrintNoJournalSafeDescription()
    {
        Console.WriteLine("Narrator:");
        Console.Write("  You step closer to the old safe, its metal cold and heavy. A "); Color.TextYellow("keypad\n");
        Console.WriteLine("  waits for the right code to unlock it. Below it is a keyhole centered.");
        Console.WriteLine("  The journal that used to lie on top of the safe is now in your pockets.");
    }
    #endregion

    // animate text for win message
    #region WIN DIALOGUE
    public static void PrintYouWin()
    {
        // Console.WriteLine("Narrator:");
        // Console.WriteLine("  You find the ring of fortune, you think for your self:");
        // Console.WriteLine("  What a journey it has been. But you finally find the ring.");
        // Console.WriteLine("  You retrieve the ring and give it to the family to recieve your pay check.");

        Console.WriteLine("Narrator:");
        Console.WriteLine("  As you open the safe, your heart races with anticipation. Inside, you");
        Console.WriteLine("  discover two rings—one belonging to Henry and the other a delicate band");
        Console.WriteLine("  worn by his beloved wife. Nestled beside the rings is a faded");
        Console.WriteLine("  photograph capturing a moment of joy, showing the young couple in their");
        Console.WriteLine("  prime, their faces filled with happiness.\n");

        Console.WriteLine("  But amidst these unique treasures, your eyes are drawn to a sealed");
        Console.WriteLine("  envelope, similar to the one that guided you here. Its edges are worn,");
        Console.WriteLine("  and the handwriting on the front is unmistakably Henry's. You feel a");
        Console.WriteLine("  sense of excitement; what other secrets and mysteries does Henry hold?");
        Console.WriteLine("  As you take the envelope in hand, you realize this journey may have");
        Console.WriteLine("  just begun, and the real adventure might still await you beyond this");
        Console.WriteLine("  room.");
    }
    #endregion
}

public class DialogueFind // double check and remove
{
    public static void PrintLetter()
    {
        string lineOne = "Dear Reader,";
        string lineTwo = "If you're holding this, it means you're curious. Good. I've left something";
        string lineThree = "for those with the patience and sharp eyes to find it. There's a safe in";
        string lineFour = "this room, and inside it, well... that's for you to discover. The code is";
        string lineFive = "hidden among the things I've left behind. You'll have to piece it together.";

        string lineSix = "I always believed that the best rewards come from a little hard work.";
        string lineSeven = "Take your time, look closely, and don't rush. If you've made it this far,";
        string lineEight = "you're already on the right track.\n";

        string lineNine = "Best of luck,";
        string lineTen = "~Henry";

        PrintByCharacter.RunCommand(lineOne); // Dear Reader,
        Console.WriteLine();
        PrintByCharacter.RunCommand(lineTwo); // If you're holding this, it means you're curious. Good. I've left something
        Console.WriteLine();
        PrintByCharacter.RunCommand(lineThree); // for those with the patience and sharp eyes to find it. There's a safe in
        Console.WriteLine();
        PrintByCharacter.RunCommand(lineFour); // this room, and inside it, well... that's for you to discover. The code is
        Console.WriteLine();
        PrintByCharacter.RunCommand(lineFive); // hidden among the things I've left behind. You'll have to piece it together.
        Console.WriteLine();
        Console.WriteLine();
        PrintByCharacter.RunCommand(lineSix); // I always believed that the best rewards come from a little hard work.
        Console.WriteLine();
        PrintByCharacter.RunCommand(lineSeven); // Take your time, look closely, and don't rush. If you've made it this far,
        Console.WriteLine();
        PrintByCharacter.RunCommand(lineEight); // you're already on the right track.
        Console.WriteLine();
        Console.WriteLine();
        PrintByCharacter.RunCommand(lineNine); // Best of luck,
        Console.WriteLine();
        PrintByCharacter.RunCommand(lineTen); // ~Henry
        Console.WriteLine();

        // Console.WriteLine("Dear Reader,");
        // Console.WriteLine("If you're holding this, it means you're curious. Good. I've left something");
        // Console.WriteLine("for those with the patience and sharp eyes to find it. There's a safe in");
        // Console.WriteLine("this room, and inside it, well... that's for you to discover. The code is");
        // Console.WriteLine("hidden among the things I've left behind. You'll have to piece it together.\n");

        // Console.WriteLine("I always believed that the best rewards come from a little hard work.");
        // Console.WriteLine("Take your time, look closely, and don't rush. If you've made it this far,");
        // Console.WriteLine("you're already on the right track.\n");

        // Console.WriteLine("Best of luck,");
        // Console.WriteLine("~Henry");
    }

    public static void PrintPocketWatch()
    {
        Console.WriteLine("Narrator:");
        Console.WriteLine("  An elegant, silver watch that has stopped ticking. Its chain is twisted,");
        Console.WriteLine("  and the hands are frozen at an odd time.\n");
    }

    public static void PrintBusinessCard()
    {
        Console.WriteLine("Narrator:");
        Console.WriteLine("  A yellowed card with the old man's face faintly visible. Only a “C” and ");
        Console.WriteLine("  a “6” can be made out from his name and number.\n");
    }

    public static void PrintShoes()
    {
        Console.WriteLine("Narrator:");
        Console.WriteLine("  A pair of worn leather shoes, scuffed from years of use. There's");
        Console.WriteLine("  something off about their weight.\n");
    }

    public static void PrintDoll()
    {
        Console.WriteLine("Narrator:");
        Console.WriteLine("  A small, porcelain doll with chipped paint and a cracked face. Its");
        Console.WriteLine("  empty eyes seem to follow you.\n");
    }

    public static void PrintJournal()
    {
        Console.WriteLine("Narrator:");
        Console.WriteLine("  A weathered journal, its pages yellowed with age. Inside, the old man's");
        Console.WriteLine("  tales about life and cryptic notes hint at something deeper. Many pages");
        Console.WriteLine("  are torn out.\n");
    }

    public static void PrintCrowbar()
    {
        Console.WriteLine("Narrator:");
        Console.WriteLine("  A solid metal bar. It feels like it could pry open just about anything.");
    }
}

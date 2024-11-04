class Dialogue
{
    #region MAIN DIALOGUE
    public static void PrintRoomDescription()
    {
        Console.WriteLine("Narrator:");
        Console.WriteLine("  As you step into the dimly lit room, a faint musty smell fills the air.");
        Console.Write("  Your feet press into a worn "); Color.TextCyan("rug"); Console.WriteLine(" as you step forward, eyes catching ");
        Console.Write("  the glint of a "); Color.TextYellow("crowbar"); Console.Write(" leaning against an aged "); Color.TextCyan("chessboard"); Console.WriteLine(". The dusty");
        Console.Write("  "); Color.TextCyan("mirror"); Console.Write(" across the room reflects the crooked "); Color.TextCyan("painting"); Console.WriteLine(" on the wall.");
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
        Console.WriteLine("  You step further onto the faded rug, firmly glued to the floor. The");
        Console.Write("   center is threadbare, and cutting around it with a "); Color.TextYellow("knife"); Console.WriteLine(" might help");
        Console.WriteLine("  lift it.");
    }

    public static void PrintRugEmptyDescription()
    {
        Console.WriteLine("Narrator:");
        Console.WriteLine("  The rug has a hole at its center, you can no longer find a note hidden");
        Console.WriteLine("  here.");
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

    public static void PrintEmptyPocketWatchDescription()
    {
        Console.WriteLine("Narrator:");
        Console.WriteLine("  The coat pocket feels lighter now, there is nothing left inside it.");
    }

    public static void PrintEmptyBusinessCardDescription()
    {
        Console.WriteLine("Narrator:");
        Console.WriteLine("  The pocket where the card was tucked is now just an empty fold of");
        Console.WriteLine("  fabric.");
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

    public static void PrintLampDescription()
    {
        Console.WriteLine("Narrator:");
        Console.WriteLine("  As you inspect the lamp closer you notice that the lampshade has been");
        Console.WriteLine("  tampered with. You wonder why but let it go for now. Maybe there is a");
        Color.TextYellow("  bulb"); Console.WriteLine(" around to insert.");
    }

    public static void PrintEmptyLampDescription()
    {
        Console.WriteLine("Narrator:");
        Console.WriteLine("  The lamp is glowing faintly from the newly inserted bulb.");
    }
    #endregion

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
        string dreamText = "Narrator:\n" +
        "  As you close your eyes, sleep quickly takes over. In the darkness, a\n" +
        "  faint image starts to form, pulling you deeper into a dream.\n" +

        "  You see the old man, his back hunched as he works with steady hands,\n" +
        "  carefully hanging the tapestry that now adorns the walls. His face is\n" +
        "  tired and fatigued, but his expression is focused. He steps back,\n" +
        "  inspecting his work. He mutters to himself, something about \"hiding\n" +
        "  things where only the patient will find them.\"\n\n" +

        "  The room feels warmer in the dream, the old man wiping sweat from his\n" +
        "  brow. He reaches into his coat pocket, pulling out a worn scraper.\n" +
        "  Slowly, he begins to smooth the edges of the tapestry.\n\n" +

        "  Then, the scene fades. His figure blurs into shadow, leaving only the\n" +
        "  image of the tapestry swaying slightly on the walls.\n";

        PrintByCharacter.RunCommand(dreamText);
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

    public static void PrintEmptyDollDescription()
    {
        Console.WriteLine("Narrator:");
        Console.WriteLine("  The spot where the doll once rested is now just an empty corner.");
    }

    public static void PrintEmptyShoesDescription()
    {
        Console.WriteLine("Narrator:");
        Console.WriteLine("  A fine layer of dust begins to settle where the shoes once stood,");
        Console.WriteLine("  leaving behind only the imprint of worn soles.");
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

    #region WIN DIALOGUE
    public static void PrintYouWin()
    {
        string winText = "Narrator:\n" +
        "  As you open the safe, your heart races with anticipation. Inside, you\n" +
        "  discover two rings—one belonging to Henry and the other a delicate band\n" +
        "  worn by his beloved wife. Nestled beside the rings is a faded\n" +
        "  photograph capturing a moment of joy, showing the young couple in their\n" +
        "  prime, their faces filled with happiness.\n\n" +

        "  But amidst these unique treasures, your eyes are drawn to a sealed\n" +
        "  envelope, similar to the one that guided you here. Its edges are worn,\n" +
        "  and the handwriting on the front is unmistakably Henry's. You feel a\n" +
        "  sense of excitement; what other secrets and mysteries does Henry hold?\n" +
        "  As you take the envelope in hand, you realize this journey may have\n" +
        "  just begun, and the real adventure might still await you beyond this\n" +
        "  room.\n";

        PrintByCharacter.RunCommand(winText);
    }
    #endregion
}

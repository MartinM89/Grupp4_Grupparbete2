using System.Text.Json;

public class Highscore
{
    public static List<Highscore> highscoreList = new List<Highscore>();
    public string? Name { get; private set; }
    public TimeSpan Time { get; private set; }

    public Highscore(string name, TimeSpan time)
    {
        this.Name = name;
        this.Time = time;
    }

    public static void CreateLoadList()
    {
        string filePath = "./Utilities/highscore.json";

        if (!File.Exists(filePath))
        {
            File.Create("./Utilities/highscore.json").Close();
        }
        else if (new FileInfo(filePath).Length.Equals(0))
        {
            return;
        }
        else
        {
            string jsonString = File.ReadAllText(filePath);
            List<Highscore> json = JsonSerializer.Deserialize<List<Highscore>>(jsonString)!;

            foreach (Highscore highscore in json)
            {
                highscoreList.Add(highscore);
            }
        }
    }

    public static void AddAndPrintList()
    {
        Console.Clear();
        Dialogue.PrintYouWin();
        PressKeyToContinue.RunCommand();

        TimeSpan finalTime = KeypadInteraction.endTime - Program.StartTime;
        string playerName = " ";

        while (true)
        {
            if (highscoreList.Count >= 0 && highscoreList.Count < 10) { }
            else if (!(finalTime < highscoreList.ElementAt(9).Time)) { break; }

            Console.Clear();
            Console.Write("Write your name (Exactly 3 letters): ");
            playerName = Console.ReadLine()!;

            if (!playerName.Length.Equals(3))
            {
                Console.WriteLine("\nName must be 3 letters.");
                PressKeyToContinue.RunCommand();
                continue;
            }
            break;
        }

        highscoreList.Add(new Highscore(playerName, finalTime));

        highscoreList.Sort((time1, time2) => time1.Time.CompareTo(time2.Time));

        if (highscoreList.Count.Equals(11))
        {
            highscoreList.RemoveRange(10, 1);
        }

        JsonSerializerOptions json = new JsonSerializerOptions { WriteIndented = true };
        string jsonString = JsonSerializer.Serialize(Highscore.highscoreList, json);
        File.WriteAllText("./Utilities/highscore.json", jsonString);

        Console.Clear();

        string tookHours;
        string tookMinutes;
        string result;

        for (int i = 0; i < highscoreList.Count; i++)
        {
            int hour = highscoreList[i].Time.Hours;
            int min = highscoreList[i].Time.Minutes;
            int sec = highscoreList[i].Time.Seconds;
            int hundredth = highscoreList[i].Time.Milliseconds / 10;

            tookHours = $"Place {i + 1} - {highscoreList[i].Name}\t\tTime: {hour}h {min}min {sec},{hundredth}sec";
            tookMinutes = $"Place {i + 1} - {highscoreList[i].Name}\t\tTime: {min}min {sec},{hundredth}sec";

            string topTenResults = hour > 0 ? tookHours : tookMinutes;

            Console.WriteLine(topTenResults);
        }

        tookHours = $"\n\tYour time: {finalTime.Hours}h {finalTime.Minutes}min {finalTime.Seconds},{finalTime.Milliseconds / 10}sec!";
        tookMinutes = $"\n\tYour time: {finalTime.Minutes}min {finalTime.Seconds},{finalTime.Milliseconds / 10}sec";

        result = finalTime.Hours > 0 ? tookHours : tookMinutes;

        Color.TextGreen(result);

        Console.WriteLine();

        PressKeyToContinue.RunCommand();
        ExitCommand.RunCommand();
    }
}

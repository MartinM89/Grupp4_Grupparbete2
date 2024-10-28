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

    public static void RunCommand()
    {
        string filePath = "./Utilities/highscore.json";

        if (!File.Exists(filePath))
        {
            File.Create("./Utilities/highscore.json").Close();
        }
        else if (new FileInfo(filePath).Length.Equals(0)) // If highscore.json is empty, don't load
        {
            return;
        }
        else
        {
            string jsonString = File.ReadAllText(filePath);
            List<Highscore> json = JsonSerializer.Deserialize<List<Highscore>>(jsonString)!;

            foreach (var highscore in json)
            {
                highscoreList.Add(highscore);
            }
        }
    }
}
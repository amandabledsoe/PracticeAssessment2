using System.Text.RegularExpressions;

// Testing AddStarWarsCharacters
// -------------------------------
string[] characters = new string[] { "Hans Solo", "Princess Laya", "YODA" };
Console.WriteLine(AddStarWarsCharacters(characters));

// Testing DeathStarCombat
// -------------------------------
Dictionary<string,int> characters2 = new Dictionary<string,int>();
characters2.Add("Hans Solo",90);
characters2.Add("Princess Laya", 95);
characters2.Add("Yoda", 85);

Console.WriteLine(DeathStarCombat(characters2));

// Testing ConvertPlanets
// -------------------------------
string[] characters3 = new string[] { "Mercury", "Venus", "Earth", "Mars", "Yavin", "Bespin", "Tatooine", "Hoth" };
List<string> thePlanetsList = new List<string>();
thePlanetsList = ConvertPlanets(characters3);

foreach (var item in thePlanetsList)
{
    Console.WriteLine(item);
}

// Testing AverageDroids
// -------------------------------
List<int> droids = new List<int>() { 2, 5, 9, 13, 22, 50, 44, 33 };
Console.WriteLine(AverageDroids(droids));

// Testing TryToCatchDarthVader
// -------------------------------
Console.WriteLine(TryToCatchDarthVader("5"));
Console.WriteLine(TryToCatchDarthVader("not5"));

static int AddStarWarsCharacters(string[] characters)
{
    string yodaInput = "[y][o][d][a]";
    for (int i = 0; i < characters.Length; i++)
    {
        if (Regex.IsMatch(characters[i], yodaInput, RegexOptions.IgnoreCase))
        {
            return i;
        }
    }
    return -1;
}
static string DeathStarCombat(Dictionary<string,int> characters)
{
    //int maxValue = characters.Max(x => x.Value);
    int maximum = characters.Values.Max();
    foreach (var item in characters)
    {
        if (item.Value == maximum)
        {
            return item.Key;
        }
    }
    return null;
}
static List<string> ConvertPlanets(string[] planets)
{
    List<string> planetsList = new List<string>();
    foreach (string planet in planets)
    {
        planetsList.Add(planet);
    }
    return planetsList.OrderByDescending(x => x).ToList();
}
static double AverageDroids(List<int> droids)
{
    List<int> evenNums = new List<int>();
    foreach (int droid in droids)
    {
        if (droid%2==0)
        {
            evenNums.Add(droid);
        }
    }
    return evenNums.Average(x => x);
}
static string TryToCatchDarthVader(string input)
{
    try
    {
        int.Parse(input);
        return "Vader Was Captured!";
    }
    catch (FormatException)
    {
        return "Vader Got Away!";
    }
}
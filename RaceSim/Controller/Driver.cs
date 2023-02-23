namespace RaceSim;

public class Driver : IParticipant
{
    public int Quality { get; set; }
    public int Performance { get; set; }
    public int Speed { get; set; }
    public bool IsBroken { get; set; }
    public string Name { get; set; }
    public int Points { get; set; }
    public IEquipment Equipment { get; set; }
    public TeamColors TeamColor { get; set; }

    public Driver(int quality, int performance, int speed, bool isBroken, string name, int points, IEquipment equipment,
        TeamColors teamColor)
    {
        Quality = quality;
        Performance = performance;
        Speed = speed;
        IsBroken = isBroken;
        Name = name ?? throw new ArgumentNullException(nameof(name));
        Points = points;
        Equipment = equipment ?? throw new ArgumentNullException(nameof(equipment));
        TeamColor = teamColor;
    }


    static void Main(string[] args)
    {
        Console.WriteLine("Start!");
    }
}

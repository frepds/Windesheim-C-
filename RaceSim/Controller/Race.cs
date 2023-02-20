namespace RaceSim;

public class Race
{
    public Track Track
    {
        get; set;
    }

    public List<IParticipant> Participants
    {
        get; set;
    }

    public DateTime StartTime
    {
        get; set;
    }

    private Random _random;
    
}
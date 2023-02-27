namespace RaceSim;

public class Race
{
    public Track Track { get; set; }
    public List<IParticipant> Participants { get; set; }
    public DateTime StartTime { get; set; }
    private Random _random;

    private Dictionary<Section, SectionData> _positions
    {
        get;
        set;
    }

    public Race(Random random, Track track, List<IParticipant> participants, DateTime startTime, Dictionary<Section, SectionData> positions)
    {
        _random = new Random(DateTime.Now.Millisecond);
        Participants = participants;
        StartTime = startTime;
        _positions = positions;
    }
}

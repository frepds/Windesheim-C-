namespace RaceSim;

public class Competition
{
    public List<IParticipant> Participants { get; set; }
    public Queue<Track> Tracks { get; set; }

    public Competition(List<IParticipant> participants, Queue<Track> tracks)
    {
        Participants = participants ?? throw new ArgumentNullException(nameof(participants));
        Tracks = tracks ?? throw new ArgumentNullException(nameof(tracks));
    }


    public Track NextTrack()
    {
        return null; // Nog niet goed
    }
}

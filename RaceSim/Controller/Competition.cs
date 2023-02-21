namespace RaceSim;

public class Competition
{
    public List<IParticipant> Participants { get; set; }
    public Queue<Track> Tracks { get; set; }

    //public public Track NextTrack()
    //{
       // return new Track("Track", new []{"left", "right", "middle"});
   // }
}
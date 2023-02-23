namespace RaceSim;

public class SectionData
{
    public IParticipant Left { get; set; }
    public IParticipant DistanceLeft { get; set;  }
    public IParticipant Right { get; set; }
    public IParticipant DistanceRight { get; set; }

    public SectionData(IParticipant left, IParticipant distanceLeft, IParticipant right, IParticipant distanceRight)
    {
        Left = left ?? throw new ArgumentNullException(nameof(left));
        DistanceLeft = distanceLeft ?? throw new ArgumentNullException(nameof(distanceLeft));
        Right = right ?? throw new ArgumentNullException(nameof(right));
        DistanceRight = distanceRight ?? throw new ArgumentNullException(nameof(distanceRight));
    }
}

namespace RaceSim;

public class Track
{
    public string name { get; set; }
    public LinkedList<Section> Sections { get; set; }

    public Track(string name, SectionTypes[] sections)
    {
        this.name = name;
        //Sections = sections;
    }
    
}
namespace RaceSim;

public class Section
{
    public SectionTypes SectionType { get; set; }
    
    public Section(SectionTypes sectionType)
    {
        SectionType = sectionType;
    }
}

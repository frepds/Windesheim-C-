namespace RaceSim;

public class Section : SectionTypes
{
    public SectionTypes SectionType { get; set; }

    public Section(SectionTypes sectionType)
    {
        SectionType = sectionType;
    }
}

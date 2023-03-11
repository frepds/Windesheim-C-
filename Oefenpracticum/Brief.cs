namespace Oefenpracticum;

public abstract class Brief
{
    public bool Aangetekend;

    public Brief(string naam, string postcode, int huisnummer, bool aangetekend)
    {
        
    }

    public string Label()
    {
        return "label";
    }
}

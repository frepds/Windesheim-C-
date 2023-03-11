namespace Oefenpracticum;

public class Post
{
    public string Naam { get; set; }
    public string Postcode { get; set; }
    public int HuisNummer { get; set; }

    public Post(string naam, string postcode, int huisNummer)
    {
        Naam = naam;
        Postcode = postcode;
        HuisNummer = huisNummer;
    }

    public string Label()
    {
        return "Label";
    }
    
}

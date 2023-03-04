namespace Windesheim._5A;

public class Program
{
    static void Main(string[] args)
    {
        // var vegamenu = menu
        //     .Where(i => i.Vegetarisch)
        //     .Select(i => i.Omschrijving)
        //     .OrderBy(i => i);
        
        // var vegamenu =
        //     from item in menu
        //     where item.Vegetarisch
        //     orderby item.Omschrijving
        //     select item.Omschrijving;

        //var mijnMenu = menu
        // .Where(i => i.Vegetarisch)
        //     .OrderBy(i => 
        //         i.Omschrijving)
        //     .Select(i => 
        //         i.Omschrijving);
        
        // var vegamenu2 =
        //     from item in menu
        //     where item.Vegetarisch
        //     orderby item.Omschrijving
        //     select item.Omschrijving;

        // var menu = new List<MenuItem>()
        // {
        //     new MenuItem("Hamburger", 562, 9.4, 2.5, false, true),
        //     new MenuItem("Milkshake", 344, 54, 0.51, true, false),
        //     new MenuItem("Friet", 330, 0.4, 0.53, true, false),
        //     new MenuItem("Vegaburger", 421, 7, 2.2, true, true),
        //     new MenuItem("Salade", 137, 7.4, 0.66, false, true)
        // };
        
        // var zoetMenu = (from item in menu
        //     where item.Suikers >= 5
        //     select
        //         item.Omschrijving).Take(3);
    }
}

class MenuItem
{
    public string Omschrijving { get; set; }
    public int KCal { get; set; }
    public double Suikers { get; set; }
    public double Zout { get; set; }
    public bool Vegetarisch { get; set; }
    public bool BevatGluten { get; set; }
}

namespace Watersport;

public class Speedboot
{
    public Boot boot = new Boot();
    public string speedBootNaam { get; set; }
    public int snelheid { get; set; }

    public Speedboot(string naam, int snelheid) 
    {
        speedBootNaam = naam;
        this.snelheid = snelheid;
    }

    public void Sturen(string richting)
    {
        Console.WriteLine($"Deze boot: '{boot.Naam}' stuurt naar {richting}");
    }
}
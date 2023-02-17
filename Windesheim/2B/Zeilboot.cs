namespace Watersport;

public class Zeilboot
{
    public string Naam;
    public int Lengte, Zeiloppervlak;
    
    public Zeilboot(string naam)
    {
        Naam = naam;
    }

    public Zeilboot(int lengte)
    {
        Lengte = lengte;
    }

    public Zeilboot(int lengte, int zeiloppervlak)
    {
        Lengte = lengte;
        Zeiloppervlak = zeiloppervlak;
    }
}
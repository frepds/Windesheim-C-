namespace Watersport
{
    public class Program
    {
        static void Main(string[] args)
        {
            Boot boot = new Boot();
            boot.Lengte = 10;
            boot.Naam = "Boot";
            Console.WriteLine($"'{boot.Naam}' is {boot.Lengte} meter lang");
        }
    }
    
    public class Boot
    {
        public int Lengte { get; set; }
        public string Naam { get; set; }
    }
}


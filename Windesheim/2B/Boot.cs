namespace Watersport
{
    public class Boot
    {
        public int Lengte { get; set; }
        public string Naam { get; set;  }

        public Boot()
        {
            
        }
        
        public Boot(int lengte)
        {
            Lengte = lengte;
        }

        public Boot(int lengte, string naam)
        {
            Lengte = lengte;
            Naam = naam;
        }
        
        public virtual void Sturen()
        {
            Console.WriteLine($"Deze boot: '{Naam}' vaart");
        }

        public string toString()
        {
            return $"'{Naam}' is {Lengte} meter lang";
        }
    }
}


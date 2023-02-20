namespace Windesheim.Random
{
    public class Program
    {
        static void Main(string[] args)
        {
            car car1 = new car();
            car1.speed = 200;
            Console.WriteLine(car1.speed);
            car car2 = new car();
            car2.speed = 300;
            Console.WriteLine(car2.speed);
            Console.WriteLine("-----");
            Auto auto = new Auto();
            auto.naam = "Fred";
            auto.intzittende = 4;
            Console.WriteLine(auto);
            Console.WriteLine("-----");
            Persoon persoon = new Persoon();
            Console.WriteLine(persoon.ToString());

            Persoon persoon2 = new Persoon();
            persoon2.Leeftijd = 10;
            Console.WriteLine(persoon2.ToString());

            Persoon persoon3 = new Persoon("Fred", "Smits", 100);
            Console.WriteLine(persoon3.ToString());
            
            
            Console.WriteLine("-----");
            Console.ReadKey();
        }
    }

    class Persoon
    {
        private System.Random random = new System.Random();
        private string _Voornaam;
        private string _Achternaam;
        private int _Leeftijd;
        private string _Id;
        private string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        
        public Persoon()
        {
            _Voornaam = "NULL";
            _Achternaam = "NULL";
            _Leeftijd = 0;
            _Id = Id;
            
        }

        public Persoon(string voornaam, string achternaam, int leeftijd)
        {
            _Voornaam = voornaam;
            _Achternaam = achternaam;
            _Leeftijd = leeftijd;
            _Id = Id;
        }

        public string Id
        {
            get
            {
                var s = new string("");
                for (int i = 0; i <= 3; i++)
                {
                    char a = alphabet[random.Next(0, 25)];
                    s += a;
                }
                return $"{random.Next(100, 1000)}{s}";
            }
        }

        public string Voornaam
        {
            get { return _Voornaam;  }
            set
            {
                if (value.Length <= 3)
                {
                    Print($"{value} is niet lang genoeg, lengte moet meer dan {value.Length} characters zijn!");
                    _Voornaam = "UNKNOWN";
                }
                else
                {
                    _Voornaam = value;
                }
            }
        }

        public string Achternaam
        {
            get { return _Achternaam;  }
            set
            {
                if (value.Length <= 3)
                {
                    Console.WriteLine($"{value} is niet lang genoeg, lengte moet meer dan {value.Length} characters zijn!");
                    _Achternaam = "UNKNOWN";
                }
                else
                {
                    _Achternaam = value;
                }
            }
        }

        public int Leeftijd
        {
            get { return _Leeftijd;  }
            set
            {
                if (value < 18)
                {
                    Console.WriteLine($"<Persoon is minderjarig, namelijk {value} jaar oud.>");
                }
                _Leeftijd = value;
            }
        }

        static void Print(string value)
        {
            Console.WriteLine(value);
        }

        public override string ToString()
        {
            return $"Burger: #{_Id} | Volledige naam: {_Voornaam} {_Achternaam} - Leeftijd: {_Leeftijd}";
        }
    }
    
    //------------------------------------------------------------------------------------------------------
    
    class Auto
    {
        private string _naam;
        public int intzittende;

        public string naam
        {
            get { return _naam; }
            set
            {
                if (value.Length < 3)
                {
                    Console.WriteLine($"{value.Length}\nNaam niet lang genoeg");
                    _naam = "Verkeerd";
                }
                else
                {
                    Console.WriteLine("Prima naam:");
                    _naam = value;
                }
            }
        }

        public override string ToString()
        {
            return $"{_naam} heeft {intzittende} intzittende.";
        }
    }
    
    
    class Vechicle
    {
        public int snelheid;
    }

    class car
    {
        private int _speed;

        public int speed
        {
            get {  return _speed;  }
            set
            {
                if (value > 100)
                {
                    _speed = 100;
                    Console.WriteLine($"Mag niet hoger dan 100. Is nu: '{value}'");
                }
                else
                {
                    _speed = value;
                }
            }
        }
        
    }
}


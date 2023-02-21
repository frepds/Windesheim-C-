using System.Runtime.InteropServices;


namespace Windesheim.Random
{
    public class Program
    {
        static void Main(string[] args)
        {
            //car car1 = new car();
            //car1.speed = 200;
            //Console.WriteLine(car1.speed);
            //car car2 = new car();
            //car2.speed = 300;
            //Console.WriteLine(car2.speed);
            //Console.WriteLine("-----");
            //Auto auto = new Auto();
            //auto.naam = "Fred";
            //auto.intzittende = 4;
            //Console.WriteLine(auto);
            //Console.WriteLine("-----");
            //Persoon persoon = new Persoon();
            //Console.WriteLine(persoon.ToString());

            //Persoon persoon2 = new Persoon();
            //persoon2.Leeftijd = 10;
            //Console.WriteLine(persoon2.ToString());

            //Persoon persoon3 = new Persoon("Fred", "Smits", 100);
            //Console.WriteLine(persoon3.ToString());
            
            
            //Console.WriteLine("-----");
            //ggd(50,35);
            opgave6();
        }

        static void opgave6()
        {
            List<int> lijst = new List<int>();
            var value = Console.ReadLine();
            int number = Int32.Parse(value);
            
            Console.WriteLine("De lijst is:");
            for (int i = 0; i <= number; i++)
            {
                if (i % 5 == 0)
                {
                    lijst.Add(i);
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine("\nDe lijst na verwijdering van de even posities:");
            for (int i = 0; i < lijst.Count; i++)
            {
                if (i % 2 == 0)
                {
                    lijst.Remove(lijst.ElementAt(i));
                }
                else
                {
                    Console.Write(lijst.ElementAt(i) + " ");
                }
            }
            
        }

        static void List()
        {
            List<int> lijst = new List<int>();
            bool run = true;
            do
            {
                var value = Console.ReadLine();
                int number = Int32.Parse(value);
                if (number == 0)
                {
                    run = false;
                }
                if (number > 0)
                {
                    for (int i = 0; i < number; i++)
                    {
                        lijst.Add(number);
                    }
                }
                if (number < 0)
                {
                    for (int i = number; i < 0; i++)
                    {
                        lijst.Remove(lijst.ElementAt(lijst.Count - 1));
                    }
                }
            } while (run);
            Console.WriteLine($"Aantal elementen: {lijst.Count}");
            Console.WriteLine($"Laatste element: {lijst.ElementAt(lijst.Count - 1)}");
            Console.Write("De lijst is: ");
            for (int i = 0; i < lijst.Count; i++)
            {
                Console.Write(lijst.ElementAt(i) + " ");
            }
        }

        static void print()
        {
            List<int> lijst = new List<int>();
            for (int i = 10000; i < 10000000; i++)
                lijst.Add(i);
            double som = 0;
            foreach (int num in lijst)
                som += num;
            Console.WriteLine($"Gemiddelde is {som / lijst.Count}");
            for (int i = 10000; i < 10000000 - 1; i++)
                Console.Write($" {lijst[i]} "); 
            Thread.Sleep(000001);
            Console.WriteLine();
        }
        
        static void PrintGrootste()
        { 
            System.Random random = new System.Random();
            int[] array = new int[60];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 100);
            }

            int highest = 0, position = 0, counter = 0;
            foreach (var number in array)
            {
                Console.WriteLine($"{(counter + 1)}: {number}");
                if (number >= highest)
                {
                    highest = number;
                    position = counter;
                }
                counter++;
            }
            Console.WriteLine($"\x1b[1mHoogste getal: {highest} - Positie: {(position + 1)}\x1b[0m");
        }

        static void PrintKleinste()
        {
            System.Random random = new System.Random();
            int[] array = new int[30];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 30);
                Console.WriteLine($"{i}: {array[i]}");
            }
            var max = array.Max();
            int smallest = 0, index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] <= max)
                {
                    smallest = array[i];
                    max = smallest;
                    index = i;
                }
            }
            Console.WriteLine($"Index: {index} | Kleinste: {smallest}");

        }
        
        
        static void ggd(int a, int b)
        {
            while (b != 0)
            {
                var rest = a % b;
                a = b;
                b = rest;
            }
            
            Console.WriteLine(a);
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


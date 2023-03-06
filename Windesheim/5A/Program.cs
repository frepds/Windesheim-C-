namespace Windesheim._5A;

public class Program
{
    static void Main(string[] args)
    {
        Action<string> print = S => Console.WriteLine(S);
        var menu = new List<MenuItem>()
        {
            new ("Hamburger", 562, 9.4, 2.5, false, true),
            new ("Milkshake", 344, 54, 0.51, true, false),
            new ("Friet", 330, 0.4, 0.53, true, false),
            new ("Vegaburger", 421, 7, 2.2, true, true),
            new ("Salade", 137, 7.4, 0.66, false, true)
        };

        var zout =
            from i in menu
            where i.Zout < 1.0
            orderby i.Zout 
            select new { i.Omschrijving, i.Zout};

        var maxSuiker = menu
            .Max(i => i.Suikers);

        var minKCal = menu
            .Min(i => i.KCal);

        foreach (var i in zout)
        {
            Console.WriteLine(i);
        }
        
        Console.WriteLine(maxSuiker);
        Console.WriteLine(minKCal);
        
        int[] temps = { 18, 17, 22, 23, 22, 21 };
        var tempsBoven20 = 
            from t in temps
            where t > 20
            orderby t descending
            select t;

        var boven20 =
            from i in menu
            where i.Suikers > 5
            orderby i.Suikers descending 
            select new { i.Omschrijving, i.Suikers };
        
        foreach (var t in boven20)
        {
            Console.WriteLine(t);
        }
        
        var namen = new List<string>() 
          { "Ernst", "Henk", "Freek", 
            "Eugène", "Hieke", "Ada", 
            "Richard", "Miranda", "Piet" };

        var Namen =
            from n in namen
            where n.Length <= 4
            orderby n.Length descending, n descending
            select n;

        var max4 = namen.Where(i => i.Length <= 4);
        
        foreach (var n in Namen)
        {
            Console.WriteLine(n);
        }
        
        Console.WriteLine("=====");
        
        foreach (var m in max4)
        {
            Console.WriteLine(m);
        }

        namen.Remove("Henk");
        namen.Remove("Freek");
        
        Console.WriteLine("=====");
        
        foreach (var m in max4)
        {
            Console.WriteLine(m);
        }
        
        namen.Add("Henk");
        namen.Add("Freek");

        Action<string> greet = name =>
        {
            var message = $"Hello {name}";
            Console.WriteLine(message);
        };
        greet("Name");

        var func = (string s, int a) =>
        {
            Console.WriteLine($"Hello {s} - You're {a}");
        };

        var function = (string firstName, string lastName, int age) =>
        {
            Console.WriteLine($"Hello {firstName}, {lastName} born {2023 - age}");
        };
        func("Josh", 100);
        function("Kyle", "Butters", 20);
    }
}



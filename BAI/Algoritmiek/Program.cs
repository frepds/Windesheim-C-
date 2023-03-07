namespace Algoritmiek;

public class Program
{
    static void LIFO()
    {
        string[] array = {"()", "((((( )))) () )", ")()", "(()()()())", "((((( ))))"};
        Stack<string> s = new Stack<string>();

        foreach (var woord in array)
        {
            for (int i = 0; i < woord.Length; i++)
            {
                if (woord[i] == '(')
                {
                    s.Push("(");
                }

                if (woord[i] == ')')
                {
                    if (s.Count != 0)
                    {
                        s.Pop();
                    }
                    else
                    {
                        s.Push("-");
                    }
                }
            }
            
            if (s.Count == 0)
            {
                Console.WriteLine($"Teststring is {woord} | RESULTAAT: GELDIG");
            }
            else
            {
                Console.WriteLine($"Teststring is {woord} | RESULTAAT: ONGELDIG");
            }
            s.Clear();
        }
    }

    static void FIFO()
    {
        Queue<char> ch1 = new Queue<char>();
        Queue<char> ch2 = new Queue<char>();
        var s = Console.ReadLine();
        
        foreach (var i in s)
        {
            var j = i;
            ch1.Enqueue(j);
        }
        // Ch1 -> Ch2
        for (var i = ch1.Count; i > 0; i--)
        {
            var c = ch1.ElementAt(i - ch1.Count);
            ch2.Enqueue(c);
            ch1.Dequeue();
        }
        
        
        // Print
        Console.WriteLine();
        foreach (var i in ch2)
        {
            Console.Write(i);
        }
        Console.WriteLine();
        
    }

    static void DICTIONARY()
    {
        Dictionary<string, string> d = new Dictionary<string, string>();
        Dictionary<string, string> exists = new Dictionary<string, string>();
        
        var path = "/Users/frederiksmits/RiderProjects/RaceSim/BAI/Algoritmiek/Namen.txt";
        string[] namen = File.ReadAllLines(path);
        foreach (var naam in namen)
        {
            var s = naam.Split(" ");
            string k = s[1]; // BSN
            string v = s[0]; // Naam
            
            if (d.ContainsKey(k))
            {
                exists.Add(k, v);
            }
            else
            {
                d.Add(k, v);
            }
        }

        for (int i = 0; i < d.Count; i++)
        {
            Console.WriteLine($"BSN: {d.ElementAt(i).Key} | NAAM: {d.ElementAt(i).Value}");
        }
        Console.WriteLine();
        for (int i = 0; i < exists.Count; i++)
        {
            Console.WriteLine($"KEY BESTAAT AL!" +
                              $"\nBSN: {d.ElementAt(i).Key} | NAAM: {d.ElementAt(i).Value}");
        }
        Console.WriteLine($"\nTotaal aantal namen: {d.Count + exists.Count}");
        Console.WriteLine($"Aantal unieke elementen is {d.Count - exists.Count}");
    }
    
    static void Main(string[] args)
    {
        DICTIONARY();
        
    }
}

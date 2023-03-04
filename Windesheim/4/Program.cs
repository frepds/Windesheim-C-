namespace Windesheim._4;

public class Program
{ 
   
    static void method()
    {
        var s = "";
        do
        {
            string[] opties = { "twix", "mars", "bounty" }; 
            s = Console.ReadLine();
            if (s.Equals("exit"))
            {
                Console.WriteLine("Goodbye!");
                return;
            }
            try
            {
                var i = int.Parse(s);
                Console.WriteLine($"Je hebt gekozen voor een {opties[i - 1]}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Geen geldig getal");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Optie bestaat niet");
            }
        } while (true);
    }
    
    static void notMain(string[] args)
    {
        method();
        Console.WriteLine("<--->");
    }
}
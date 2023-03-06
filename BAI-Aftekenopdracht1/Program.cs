namespace BAI_Aftekenopdracht1;

public class Program
{
    static void Main(string[] args)
    {
        Dictionary<int, int> dictionary = new Dictionary<int, int>();
        dictionary.Add(1,1);
        dictionary.Add(2,1);
        dictionary.Add(3,2);

        Console.WriteLine();
        
        foreach (var i in dictionary)
        {
            Console.WriteLine(i.Value);
        }

        
        List<int> list = new List<int> { 1, 3, 5, 7, 3, 8, 9, 5 };
        Aftekenopdracht1.Opg1FilterList(list);

        // Opgave 2
        Console.WriteLine("Opgave 2:");
        Queue<int> queue = Aftekenopdracht1.Opdr2AQueue50();
        Stack<int> stack = Aftekenopdracht1.Opdr2BStackFromQueue(queue);
        foreach (var s in stack)
        {
            Console.Write($"{s} ");
        }
        
        //Opgave 3
        Console.WriteLine("\nOpgave 3:");
        // Stack 1
        Stack<int> stackExample1 = Aftekenopdracht1.Opdr3RandomNumbers(100, 150, 10);
        foreach (var i in stackExample1) { Console.Write(i + " "); } Console.WriteLine();
        // Stack 2
        Stack<int> stackExample2 = Aftekenopdracht1.Opdr3RandomNumbers(10, 15, 6);
        foreach (var i in stackExample2) { Console.Write(i + " "); } Console.WriteLine();

       
        
        
        Console.ReadKey();
    }
}
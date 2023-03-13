namespace Les6A;

public delegate bool Method(int i, int j);

public class Program
{
    public Program()
    {
        Method isKleiner = (i, i1) => Method(i, i1);
    }
    
    static void Main(string[] args)
    {
        Console.WriteLine("Hello world");
    }
}
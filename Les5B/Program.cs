namespace Les5B;

public class Program
{
    public Program()
    {
        Go go = Lopen;
        go();
    }

    public delegate void Go();

    public static void Lopen()
    {
        Console.WriteLine("Hello world");
    }
    
    
    public static void Main(string[] args)
    {
        Program p = new Program();
    }
}
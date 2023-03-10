namespace Les5B;
delegate void Go();

public class Program
{
    public Program()
    {
        Go go = Lopen;
        go();
    }
    
    public static void Lopen()
    {
        Console.WriteLine("Aan het lopen...");
    }
    
    
    public static void Main(string[] args)
    {
        Program p = new Program();
        PrintValues pr = new PrintValues();
        //PrintValues pri = new PrintValues(300);
        //Console.ReadKey();
    }
}
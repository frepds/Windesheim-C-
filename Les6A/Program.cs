namespace Les6A;


public class Program
{
    public Action<string> ToespraakHouden;
    
    public Program()
    {
        ToespraakHouden = (string woorden) => Console.WriteLine($"Toespraak: {woorden}");
        ToespraakHouden("Beste vrienden, ik ben blij hier vandaag te zijn.");
    }
    
    static void Main(string[] args)
    {
        Program p = new Program();
    }
}
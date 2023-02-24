namespace Data;

public class Data
{
    private string Content;
    
    static void notMain(string[] args)
    {
        Data data1 = new Data();
        data1.Content = "Content A";
        Console.WriteLine($"data1 {data1.Content}");

        Data data2 = data1;
        data2.Content = "Content B";
        
        Console.WriteLine($"data1 {data1.Content}");
        Console.WriteLine($"data2 {data2.Content}");
    }
}
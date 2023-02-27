namespace Data;

public class Program
{
    static void Rectangular()
    {
        int[,]? rectangular;
        rectangular = new int[,]
        {
            {21, 19, 17, 23, 25, 25, 28 }, 
            {27, 27, 25, 22, 20, 10, 20 }, 
            {21, 23, 23, 0, 0, 0, 0}
        };
        var x = 0;
        foreach (var a in rectangular)
        {
            x++;
            if (x == rectangular.GetLength(1))
            {
                Console.Write($"|{a}|");
                Console.WriteLine();
                x = 0;
            }
            else
            {
                Console.Write($"|{a}");
            }
        }
    }

    static void Jagged()
    {
        int[][] jagged = new int[3][];
        jagged[0] = new[] {21,19,17,23,25,25,28};
        jagged[1] = new[] {27,27,25,22,20,10,20};
        jagged[2] = new[] {21,23,23};
        
        for (int i = 0; i < jagged.Length; i++)
        {
            for (int j = 0; j < jagged[i].Length; j++)
            {
                if (j == jagged[i].Length - 1)
                {
                    Console.Write($"|{jagged[i][j]}|");
                }
                else
                {
                    Console.Write($"|{jagged[i][j]}");
                }
            }
            Console.WriteLine();
        }
    }
    
    static void Main(string[] args)
    {
        Rectangular();
        Console.WriteLine();
        Jagged();

    }
}
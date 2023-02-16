namespace RaceSim;

public interface IEquipment
{
    static void Main(string[] args)
    { 
        for (var ch='A'; ch <= 'Z'; ch++)
        {
            Console.Write($"{ch} ({(int)ch})\t");
            if (ch % 4 == 0)
            {
                Console.WriteLine();
            }
        }
        
        Console.WriteLine("\n");
        
        
        Console.WriteLine(123456789 % 10);
        int[] amount = {1,2,3,4,5,6,7,8,9,10};
        for (int i = 0; i < amount.Length; i++)
        {
            Console.WriteLine(amount[i]);
        }
        Console.WriteLine("Amount enter");
        int amountEnter = Convert.ToInt32(Console.ReadLine());
        int j = 1;
        for (int i = 0; i <= amountEnter; i++)
        {
            if (i == 0)
            {
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine(j);
                j++;
            }
        }
        Console.WriteLine("Press any key to exit.");
    }
}
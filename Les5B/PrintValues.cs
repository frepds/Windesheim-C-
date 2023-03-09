namespace Les5B;

public class PrintValues
{
        public delegate void Print(int value);

        public PrintValues()
        {
                Print PrintDel = PrintNumbers;
                PrintDel(200);
                PrintDel = PrintMoney;
                PrintDel(300);
                PrintDel += PrintMoney;
                PrintDel(200);
        }

        public static void PrintNumbers(int num)
        {
                Console.WriteLine("Number: {0,-12:N0}", num);
        }

        public static void PrintMoney(int money)
        {
                Console.WriteLine($"Money: {money}");
        }
        
}

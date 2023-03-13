namespace Les5B;
public delegate void Print(int value);
public delegate void Array(int[] n);
public delegate bool Del(int x, int y);

public class PrintValues
{
        public PrintValues()
        {
                //Print PrintDel = PrintNumbers;
                //PrintDel(200);
                //PrintDel = PrintMoney;
                //PrintDel(200);
                //Console.WriteLine("+=");
                //PrintDel += PrintMoney;
                //PrintDel(300);
                
                //Console.WriteLine("*****");
                //PrintDel = Square;
                //PrintDel?.Invoke(200);

                Array a = BubbleSort;
                int[] array = {6,5,3,1,8,7,2,4};
                a(array);
                foreach (var i in array)
                {
                        Console.Write($"{i} ");
                }
        }

        public static void PrintNumbers(int num)
        {
                Console.WriteLine($"Number: {num}");
        }

        public static void PrintMoney(int money)
        {
                Console.WriteLine($"Money: {money - 50}");
        }

        public static void Square(int n)
        {
                Console.WriteLine(n * n);
        }

        public static bool GreaterThan(int first, int second)
        {
                return first > second;
        }
        
        public static void BubbleSort(int[] items)
        {
                int i; int j; int temp;
                
                if (items == null) { return; }

                for (i = items.Length - 1; i >= 0; i--)
                {
                        for (j = 1; j <= i; j++)
                        {
                                if (GreaterThan(i - 1, j).Equals(true))
                                {
                                        temp = items[j - 1];
                                        items[j - 1] = items[j]; 
                                        items[j] = temp; 
                                }
                                //if (items[j - 1] > items[j])
                                //{
                                //      temp = items[j - 1];
                                //      items[j - 1] = items[j];
                                //      items[j] = temp;
                                //}  
                        } 
                }
        }
}

namespace BAI_Aftekenopdracht1;

public class Program
{
    static void Main(string[] args)
    {
        List<int> list = new List<int>() { 1, 3, 5, 7, 3, 8, 9, 5 };
        Aftekenopdracht1.Opg1FilterList(list);


        Queue<int> queue = Aftekenopdracht1.Opdr2AQueue50();
        Stack<int> stack = Aftekenopdracht1.Opdr2BStackFromQueue(queue);
        Console.WriteLine(stack);

        //Stack st = new Stack();

        //st.Push("Fred");
        //st.Push('B');
        //st.Push('C');
        //st.Push('D');

        //Console.WriteLine("Current stack: ");
        //foreach (var c in st) {
        //    Console.Write(c + " ");
        //}

        //Console.WriteLine();
    }
}
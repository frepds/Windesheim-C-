namespace BAI_Aftekenopdracht1;

public class Aftekenopdracht1
{
    public static void Opg1FilterList(List<int> lijst)
    {
        Dictionary<int, int> dictionary = new Dictionary<int, int>();
        int num = 0;
        foreach (var list in lijst)
        {
            dictionary.Add(num, lijst[num]);
            Console.WriteLine(num + " " + lijst[num]);
            num++;
        }
        
        
    }

    public static Queue<int> Opdr2AQueue50()
    { 
        Queue<int> queue = new Queue<int>();
        for (var i = 1; i <= 50; i++)
        {
            queue.Enqueue(i);
        }
        
        return queue;
    }

    public static Stack<int> Opdr2BStackFromQueue(Queue<int> q)
    {
        Stack<int> tijdelijkeStack = new Stack<int>();
        while (q.Count > 0)
        {
            int value = q.Dequeue();
            if ((value % 4) == 0)
            {
                tijdelijkeStack.Push(value);
            }
        }
        return tijdelijkeStack;
    }

    public static Stack<int> Opdr3RandomNumbers(int lower, int upper, int count)
    {
        Random r = new Random();
        var n = 1;
        do
        {
            int number = r.Next(lower, upper);
            
        } while (n < count);
        return null;
    }
    
}
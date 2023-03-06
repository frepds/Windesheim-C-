namespace BAI_Aftekenopdracht1;

public class Aftekenopdracht1
{
    public static void Opg1FilterList(List<int> lijst)
    {
        Dictionary<int, int> dictionary = new Dictionary<int, int>();
        
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
        var r = new Random();
        int counter = 0;

        Stack<int> s = new Stack<int>();

        do
        {
            var generated = r.Next(lower, (upper + 1));
            if (s.Contains(generated))
            {
                bool run = true;
                do
                {
                    var newGenerated = r.Next(lower, upper);
                    if (!s.Contains(newGenerated))
                    {
                        s.Push(newGenerated);
                        run = false;
                    }
                } while (run);
                Console.WriteLine("[CONTAINS] " + (counter + 1) + ": " + generated);
            }
            else
            {
                s.Push(generated);
            }
            //Console.WriteLine((counter + 1) + ": " + generated);
            counter++;
        } while (counter < count);
        return s;
    }
    
}
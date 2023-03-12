using System;
using System.Collections.Generic;
using System.Linq;

public class Aftekenopdracht1
{
    public static void Opg1FilterList(List<int> lijst)
    { 
        var dictionary = new Dictionary<int, int>(); 
        var count = 0;

        while (count < lijst.Count)
        {
            if (!dictionary.ContainsValue(lijst[count]))
            {
                
            }
            //dictionary.Add(count, dictionary.ContainsValue(lijst[count]) ? lijst[count] : 1234);
            count++;
        }

        count = 0;
        List<int> l = new List<int>();
        while (count < dictionary.Count)
        {
            if (!dictionary.ContainsValue(1234))
            {
                l.Add(dictionary[count]);
                
            }
            count++;
        }

        foreach (var n in l)
        {
            Console.WriteLine(n);
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
            var value = q.Dequeue();
            if (value % 4 == 0)
            {
                tijdelijkeStack.Push(value);
            }
        }
        return tijdelijkeStack;
    }

    public static Stack<int> Opdr3RandomNumbers(int lower, int upper, int count)
    { 
        var r = new Random();
        var counter = 0;

        Stack<int> s = new Stack<int>();

        do
        {
            var generated = r.Next(lower, upper + 1);
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
            }
            else
            {
                s.Push(generated);
            }
            counter++;
        } while (counter < count);
        return s;
    }
}

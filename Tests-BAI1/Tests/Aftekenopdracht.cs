using System;
using System.Collections.Generic;
using System.Linq;

public class Aftekenopdracht1
{
    // Opgave 1
    public static void Opg1FilterList(List<int> lijst)
    { 
        Dictionary<int, int> dictionary = new Dictionary<int, int>();

        foreach (var n in lijst)
        {
            if (dictionary.ContainsKey(n))
            {
                dictionary[n]++;
                Console.WriteLine(n);
            }
            else
            {
                dictionary[n] = 1;
            }
        }

        foreach (var entry in dictionary.Where(e => e.Value == 1))
        {
            lijst.RemoveAll(n => n == entry.Key);
        }
    }

    
    // Opgave 2
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

    // Opgave 3
    public static Stack<int> Opdr3RandomNumbers(int lower, int upper, int count)
    { 
        var r = new Random();
        var counter = 0;

        Stack<int> s = new Stack<int>();

        while (s.Count < count)
        {
            int n = r.Next(lower, upper + 1);
            if (!s.Contains(n))
            {
                s.Push(n);
            }
        }
        return s;
    }
}




// Opgave 1

//   public static void Opg1FilterList(List<int> lijst)
//   { 
//       Dictionary<int, int> dictionary = new Dictionary<int, int>();
//       var i = lijst.Count;
//       var j = 0;
//           
//       // Fill
//       while (i > 0)
//       {
//           dictionary.Add(j, lijst[j]);
//           j++; i--;
//       }
//          
//       // Reset
//       i = lijst.Count;
//       j = 0;
//           
//       // Remove
//       while (i > 0)
//       {
//           int length = lijst.Count(), comparison = 0;
//           var num = dictionary[j];
//           var count = 0;
//           //Console.WriteLine(num);
//           
//           while (length > 0)
//           {
//               if (dictionary[comparison].Equals(num))
//               {
//                   count++;
//               }
//               comparison++;
//               length--;
//           }
//           
//           if (count <= 1)
//           {
//               dictionary.Remove(j);
//           }
//              
//           j++; i--; 
//           count = 0; 
//       }
//   }

// Opgave 3

// public static Stack<int> Opdr3RandomNumbers(int lower, int upper, int count)
// { 
//     var r = new Random();
//     var counter = 0;
//
//     Stack<int> s = new Stack<int>();
//
//     do
//     {
//         var generated = r.Next(lower, upper + 1);
//         if (s.Contains(generated))
//         {
//             bool run = true;
//             do
//             {
//                 var newGenerated = r.Next(lower, upper);
//                 if (!s.Contains(newGenerated))
//                 {
//                     s.Push(newGenerated);
//                     run = false;
//                 }
//             } while (run);
//         }
//         else
//         {
//             s.Push(generated);
//         }
//         counter++;
//     } while (counter < count);
//     return s;
// }

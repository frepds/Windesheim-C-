namespace Algoritmiek;

public class Test
{
    static void test()
    {
        string test = "";
        Stack<string> s = new Stack<string>();
        for (int i = 0; i < test.Length; i++)
        {
            if (test[i] == '(')
            {
                s.Push("(");
            }

            if (test[i] == ')')
            {
                if (s.Count != 0)
                {
                    s.Pop();
                }
                else
                {
                    s.Push("-");
                }
            }
        }
        
        
        if (s.Count == 0)
        {
            Console.WriteLine("RESULTAAT: GELDIG");
        }
        else
        {
            Console.WriteLine("RESULTAAT: ONGELDIG");
        }
    }}
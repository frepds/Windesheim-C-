namespace Windesheim
{
    public class Test
    {
        static void notMain(string[] args)
        {
            class2 classExample = new class2();
            classExample.example();
            classExample.snelheid = 10;
            Console.WriteLine(classExample.snelheid);
                
        }
    }

    public class class2
    {
        public int snelheid { set; get; }
        public void example()
        {
            Console.WriteLine("Hello");
        }
    }
}

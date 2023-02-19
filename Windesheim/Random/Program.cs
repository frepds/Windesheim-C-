namespace Windesheim.Random
{
    public class Program
    {
        static void Main(string[] args)
        {
            car car1 = new car();
            car1.speed = 200;
            Console.WriteLine(car1.speed);
            car car2 = new car();
            car2.speed = 300;
            Console.WriteLine(car2.speed);
            Console.ReadKey();
        }
    }

    class Vechicle
    {
        public int snelheid;
    }

    class car
    {
        private int _speed;

        public int speed
        {
            get {  return _speed;  }
            set
            {
                if (value > 100)
                {
                    _speed = 100;
                    Console.WriteLine($"Mag niet hoger dan 100. Is nu: '{value}'");
                }
                else
                {
                    _speed = value;
                }
            }
        }
        
    }
    
}


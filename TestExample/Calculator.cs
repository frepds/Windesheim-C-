namespace Data;

public class Calculator
{
    public static int Add(int x, int y)
    {
        return x + y;
    }

    public static int Subtract(int x, int y)
    {
        return x - y;
    }

    public static int Multiply(int x, int y)
    {
        return x * y;
    }

    public static int Division(int x, int y)
    {
        return x / y;
    }

    public static int Modulo(int x, int y)
    {
        return x % y;
    }

    public static int CelsiusToFahrenheit(int c)
    {
        return (int) (c * 1.8) + 32;
    }
    
    public static int FahrenheitToCelsius(int f)
    {
        return (int) ((f - 32) / 1.8);
    }
    
}

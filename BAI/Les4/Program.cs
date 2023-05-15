// Opgave 8
static void Skip()
{
    Console.WriteLine();
}

static void Break()
{
    Console.Write(" ");
}


Console.WriteLine("Opgave 8, geef nu een tekst!\n\nDe ingevoerde tekst is:");
var s = Console.ReadLine();
Console.WriteLine("\nEn de tekst na de converie is:\n");

var array = s.Split(" ");
foreach (var n in array)
{
    for (int i = 0; i < n.Length; i++)
    {
        var c = n[i];
        if (i == 0)
        {
            c = char.Parse(c.ToString().ToUpper());
        }
        Console.Write(c);
    }
    Break();
}
Skip();
foreach (var n in array)
{
    for (var i = 0; i < n.Length; i++)
    {
        var c = n[i];
        Console.Write(i != 0 ? char.Parse(c.ToString().ToUpper()) : c);
    }
    Break();
}
Skip();
Console.ReadKey();

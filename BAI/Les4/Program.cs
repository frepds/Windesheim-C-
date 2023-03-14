// Opgave 8
Console.WriteLine("Opgave 8, geef nu een tekst!\n\nDe ingevoerde tekst is:");
var s = Console.ReadLine();
Console.WriteLine("\nEn de tekst na de converie is:\n");

var array = s.Split(" ");
foreach (var i in array)
{
    var c = i[0];
    Console.Write($"{i.Replace(c, char.Parse(c.ToString().ToUpper()))} ");
}

Console.WriteLine();

foreach (var n in array)
{
    for (var i = 0; i < n.Length; i++)
    {
        var c = n[i];
        Console.Write(i != 0 ? char.Parse(c.ToString().ToUpper()) : c);
    }
    Console.Write(" ");
}
Console.WriteLine();
Console.ReadKey();

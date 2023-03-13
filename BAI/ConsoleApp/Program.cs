// See https://aka.ms/new-console-template for more information

List<int> list = new List<int>() { 1, 4,4,4,4 ,3, 5, 7, 3, 8, 9, 5 };
Aftekenopdracht1.Opg1FilterList(list);

foreach (var n in list)
{
    Console.Write($"{n} ");
}

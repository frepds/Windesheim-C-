// Deze code is een hulpmiddel om je werk te controleren
// Alle aanpassingen die je in dit bestand maakt worden niet meegenomen in de beoordeling

using Oefentoets1;

Console.WriteLine("Hello world");

// Opdrachten 1a t/m 1d

//Burger b1 = new Burger("Reggie", "Cardin", new DateTime(1977, 6, 21));
//b1.IBAN = "NL77INGB0066778899";
//Console.WriteLine(b1.Informatie());

//Burger b2 = new Burger("Kolby", "Carey", new DateTime(2000, 3, 15));
//b2.IBAN = "NL52INGB0000237456";
//Console.WriteLine(b2.Informatie());

//Burger b3 = new Burger("Mervyn", "Elden", new DateTime(2020, 1, 31));
//b3.IBAN = "NL33RABO0007117633";
//Console.WriteLine(b3.Informatie());

//Burger b4 = new Burger("Nora", "Bradly", new DateTime(1984, 8, 3));
//b4.IBAN = "NL67RBRB0000342133";
//Console.WriteLine(b4.Informatie());

//Burger b5 = new Burger("Austen", "Zelma", new DateTime(1995, 4, 11));
//b5.IBAN = "NL11SNSB0001657291";
//Console.WriteLine(b5.Informatie());

//Burger b6 = new Burger("Erna", "Macie", new DateTime(2006, 11, 26));
//b6.IBAN = "NL98INGB0006768465";
//Console.WriteLine(b6.Informatie());
//Console.WriteLine();

//Bedrijf p1 = new Bedrijf("Restaurant Eten&Zo", new DateTime(2012, 1, 31));
//Console.WriteLine(p1.Informatie());
//Console.WriteLine();

//try
//{
//    b1.IBAN = "DE12RABO12345678";
//}
//catch(InfoException ie)
//{
//    Console.WriteLine(ie.Message);
//}

//try
//{
//    b1.IBAN = "NL12RABO1234567";
//}
//catch (InfoException ie)
//{
//    Console.WriteLine(ie.Message);
//}
//Console.WriteLine();

//p1.IBAN = "NL36INGB0016736585";
//Console.WriteLine($"{p1.Informatie()} heeft als banknummer {p1.IBAN}");
//Console.WriteLine();

// Opdrachten 1e t/m 1g

//Register<Burger> burgers = new Register<Burger>();
//burgers.Toevoegen(b1);
//burgers.Toevoegen(b2);
//burgers.Toevoegen(b3);
//burgers.Toevoegen(b4);
//burgers.Toevoegen(b5);
//burgers.Toevoegen(b6);

//foreach(var nummer in burgers.RekeningNummers(Banken.ING, 2))
//{
//    Console.WriteLine(nummer);
//}
//Console.WriteLine();

//if (burgers.Verwijderen(b5))
//{
//    Console.WriteLine($"Burger {b5.Voornaam} {b5.Achternaam} verwijderd");
//}
//if (burgers.Verwijderen(b2))
//{
//    Console.WriteLine($"Burger {b2.Voornaam} {b2.Achternaam} verwijderd");
//}
//if (burgers.Verwijderen(b4))
//{
//    Console.WriteLine($"Burger {b4.Voornaam} {b4.Achternaam} verwijderd");
//}
//Console.WriteLine();

//foreach (var nummer in burgers.RekeningNummers(Banken.ING, 2))
//{
//    Console.WriteLine(nummer);
//}
//Console.WriteLine();

//if (burgers.OngedaanMaken())
//{
//    Console.WriteLine("Undo verwijdering");
//}
//if (burgers.OngedaanMaken())
//{
//    Console.WriteLine("Undo verwijdering");
//}
//Console.WriteLine();

//foreach (var nummer in burgers.RekeningNummers(Banken.ING, 4))
//{
//    Console.WriteLine(nummer);
//}
//Console.WriteLine
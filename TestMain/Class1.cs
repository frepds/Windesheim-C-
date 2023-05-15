namespace TestMain;
using Newtonsoft.Json;

public class Class1
{
    private const int TotalQuestions = 12;
    private static readonly Dictionary<int, string> QuestionDictionary = new(TotalQuestions);
    private static readonly Dictionary<int, string> AnswerDictionary = new(TotalQuestions);
    
    private static void FillDictionaryQuestions(int n, int g)
    {
        switch (g)
        { 
            case 0: 
                QuestionDictionary.Add(n, "Duim"); 
                break;
            case 1: 
                QuestionDictionary.Add(n, "Geit"); 
                break;
            case 2: 
                QuestionDictionary.Add(n, "Kip"); 
                break;
            case 3: 
                QuestionDictionary.Add(n, "Leeuw"); 
                break;
            case 4: 
                QuestionDictionary.Add(n, "Kat"); 
                break;
            case 5: 
                QuestionDictionary.Add(n, "Rat"); 
                break;
            case 6: 
                QuestionDictionary.Add(n, "Vuur"); 
                break;
            case 7: 
                QuestionDictionary.Add(n, "Zaag"); 
                break;
            case 8: 
                QuestionDictionary.Add(n, "Wiel"); 
                break;
            
        }
    }
    
    private static void FillDictionaryAnswers(int n, int g)
    {
        switch (g)
        { 
            case 0: 
                AnswerDictionary.Add(n, "Duim"); 
                break;
            case 1: 
                AnswerDictionary.Add(n, "Geit"); 
                break;
            case 2: 
                AnswerDictionary.Add(n, "Kip"); 
                break;
            case 3: 
                AnswerDictionary.Add(n, "Leeuw"); 
                break;
            case 4: 
                AnswerDictionary.Add(n, "Kat"); 
                break;
            case 5: 
                AnswerDictionary.Add(n, "Rat"); 
                break;
            case 6: 
                AnswerDictionary.Add(n, "Vuur"); 
                break;
            case 7: 
                AnswerDictionary.Add(n, "Zaag"); 
                break;
            case 8: 
                AnswerDictionary.Add(n, "Wiel"); 
                break;
        }
    }
    
    

    public static void Main()
    {
        var random = new Random();
        const int n = 12;
        for (var i = 0; i < n; i++)
        {
            var r1 = random.Next(9);
            FillDictionaryQuestions(i, r1);
            var r2 = random.Next(9);
            FillDictionaryAnswers(i, r2);
        }
        
        for (var i = 0; i < n; i++)
        {
            Console.Write($"Antwoord [{QuestionDictionary.Keys.ElementAt(i)}: {QuestionDictionary.Values.ElementAt(i)}] " +
                          "| " +
                          $"Gebruiker [{AnswerDictionary.Keys.ElementAt(i)}: {AnswerDictionary.Values.ElementAt(i)}] - ");
            Console.Write(QuestionDictionary.Values.ElementAt(i) == AnswerDictionary.Values.ElementAt(i));
            Console.WriteLine();
        }
    }
}
namespace TestMain;

public class Class1
{
    private const int TotalQuestions = 12;

    private static readonly Dictionary<int, Tuple<string, string>> QuestionDictionary = new(TotalQuestions);
    private static readonly Dictionary<int, Tuple<string, string>> AnswerDictionary = new(TotalQuestions);
    
    private static void FillDictionaryQuestions(int Number, int TypeSound, int AudioSound)
    {
        var Sound = TypeSound switch
        {
            0 => "Mono-Left",
            1 => "Mono-Right",
            2 => "Stereo",
        };

        var Audio = AudioSound switch
        {
            0 => "Duim",
            1 => "Geit",
            2 => "Kip",
            3 => "Leeuw",
            4 => "Kat",
            5 => "Rat",
            6 => "Vuur",
            7 => "Zaag",
            8 => "Wiel",
        };

        var Inner = new Tuple<string, string>(Sound, Audio);
        QuestionDictionary.Add(Number, Inner);
    }
    
    private static void FillDictionaryAnswers(int Number, int AudioSound)
    {
        var InnerTuple = QuestionDictionary[Number];
        var Key = InnerTuple.Item1;

        var Audio = AudioSound switch
        {
            0 => "Duim",
            1 => "Geit",
            2 => "Kip",
            3 => "Leeuw",
            4 => "Kat",
            5 => "Rat",
            6 => "Vuur",
            7 => "Zaag",
            8 => "Wiel",
        };
        
        var Inner = new Tuple<string, string>(Key, Audio);
        AnswerDictionary.Add(Number, Inner);
    }
    
    

    public static void Main()
    {
        var random = new Random();

        for (var i = 0; i < TotalQuestions; i++)
        {
            var r1 = random.Next(9);
            var r2 = random.Next(3);
            FillDictionaryQuestions(i, r2, r1);
        }
        
        for (var i = 0; i < TotalQuestions; i++)
        {
            var r1 = random.Next(9);
            FillDictionaryAnswers(i, r1);
        }
        
        
        var output1 = string.Join(", \n", QuestionDictionary.Select(entry => $"Key: {entry.Key}, Value1: {entry.Value.Item1}, Value2: {entry.Value.Item2}"));
        Console.WriteLine(output1);
        
        Console.WriteLine("\nAnswers:\n");
        
        var output2 = string.Join(", \n", AnswerDictionary.Select(entry => $"Key: {entry.Key}, Value1: {entry.Value.Item1}, Value2: {entry.Value.Item2}"));
        Console.WriteLine(output2);

        Console.WriteLine("\n");
        
        for (int i = 0; i < TotalQuestions; i++)
        {
            var questionString2 = QuestionDictionary[i].Item2;
            var answerString2 = AnswerDictionary[i].Item2;

            Console.WriteLine(questionString2 == answerString2
                ? $"Question {i + 1}: String2 values match {questionString2} - {answerString2}"
                : $"Question {i + 1}: String2 values do not match {questionString2} - {answerString2}");
        }
       
    }
}
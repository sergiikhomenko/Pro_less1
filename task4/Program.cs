namespace task4;
/*
 * Створіть колекцію, в яку можна записувати два значення одного слова,
 * на кшталт російсько-англо-українського словника. І в ній можна для
 * українського слова знайти або лише російське значення, або лише
 * англійське та вивести його на екран. 
 */
class Program
{
    static void Main(string[] args)
    {
        List<Words> wordsList = new List<Words>
        {
            Words.AddWord("книга", "книга", "book"),
            Words.AddWord("стіл", "стол", "table"),
            Words.AddWord("сонце", "солнце", "sun"),
        };
        Console.WriteLine("Введіть слово для пошуку");
        string findWords = Console.ReadLine();
        
        FindeRus(wordsList, findWords);
        
        FindeEn(wordsList, findWords);
    }

    public static void FindeRus(List<Words> listWords, string wordsToFide)
    {
        foreach (var words in listWords)
        {
            if (words.Uk == wordsToFide)
            {
                Console.WriteLine($" {words.Uk} - {words.Ru}");
            }
        }
        
    }

    public static void FindeEn(List<Words> wordsList, string wordsToFide)
    {
        foreach (var words in wordsList)
        {
            if (words.Uk == wordsToFide)
            {
                Console.WriteLine($" {words.Uk} - {words.En}");
            }
        }
    }
}
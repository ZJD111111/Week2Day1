using System.Text.RegularExpressions;
namespace app;
class ReverseSentense
{
    public void ReverseSentenseMethod(string sentense)
    {
        char[] separators = { '.', ',', ':', ';', '=', '(', ')', '&', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' };
        string[] words = sentense.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        string[] separatorsBetweenWords = Regex.Split(sentense, @"\w+");
        for (int i = 0; i < separatorsBetweenWords.Length; i++)
        {
            Console.WriteLine(separatorsBetweenWords[i]);
        }
        Array.Reverse(words);
        string reversedSentense = "";
        for (int i = 0; i < words.Length; i++)
        {
            reversedSentense += words[i];
            if (i < separatorsBetweenWords.Length)
            {
                reversedSentense += separatorsBetweenWords[i];
            }
        }
        Console.WriteLine(reversedSentense);
    }
}
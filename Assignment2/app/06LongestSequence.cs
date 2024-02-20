namespace app;
class ReverseSentense
{
    public void ReverseSentenseMethod(string sentense)
    {
        char[] separators = { '.', ',', ':', ';', '=', '(', ')', '&', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' };
        string[] words = sentense.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        List<String> separatorsBetweenWords = new List<string>();
        for (int i = 0; i < sentense.Length; i++)
        {
            if (separators.Contains(sentense[i]))
            {
                separatorsBetweenWords.Add(sentense[i].ToString());
            }
        }
        Array.Reverse(words);
        string reversedSentense = "";
        for (int i = 0; i < words.Length; i++)
        {
            reversedSentense += words[i];
            if (i < separatorsBetweenWords.Count)
            {
                reversedSentense += separatorsBetweenWords[i];
            }
        }

        Console.WriteLine(reversedSentense);
    }
}

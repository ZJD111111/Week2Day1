namespace app;
class ReverseLetters
{
    public void ReverseLetter(string word)
    {
        char[] charArray = word.ToCharArray();
        Array.Reverse(charArray);
        string reversed1 = new string(charArray);
        string reversed2 = "";
        for (int i = word.Length - 1; i >= 0; i--)
        {
            reversed2 += word[i];
        }
        Console.WriteLine("method1: {0}", reversed1);
        Console.WriteLine("method2: {0}", reversed2);
    }
}
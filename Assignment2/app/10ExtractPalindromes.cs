namespace app1;
class ExtractPalindromes
{
    public void ExtractPalindrome(string text)
    {
        string[] words = text.Split(new char[] { ' ', ',', '.', ':', ';', '!', '?', '"', '\'', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
        HashSet<string> palindromeSet = new HashSet<string>();
        foreach (string word in words)
        {
            if (IsPalindrome(word))
            {
                palindromeSet.Add(word);
            }
        }
        List<string> sortedPalindromes = palindromeSet.OrderBy(p => p).ToList();
        Console.WriteLine(string.Join(", ", sortedPalindromes));
    }

    static bool IsPalindrome(string word)
    {
        int left = 0;
        int right = word.Length - 1;
        while (left < right)
        {
            if (char.ToLower(word[left]) != char.ToLower(word[right]))
            {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }
}
namespace app1;

class LongestSequences
{
    public void LongestSequence(int[] array)
    {
        int longestLeft = 0;
        int longestRight = 0;
        int left = 0;
        int longest = 0;
        for (int right = 1; right < array.Length; right++)
        {
            if (array[right] == array[left])
            {
                continue;
            }
            else
            {
                int len = right - left;
                if (len > longest)
                {
                    longest = len;
                    longestLeft = left;
                    longestRight = right;
                }
                left = right;
            }
        }
        for (int i = longestLeft; i < longestRight; i++)
        {
            Console.Write(array[i] + " ");
        }
    }
}
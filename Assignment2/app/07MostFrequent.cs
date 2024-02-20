namespace app1;
class MostFrequents
{
    public void MostFrequent(int[] array)
    {
        int mostFrequent = 0;
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            int currentCount = 0;
            for (int j = 0; j < array.Length; j++)
            {
                if (array[i] == array[j])
                {
                    currentCount++;
                }
            }
            if (currentCount > count)
            {
                count = currentCount;
                mostFrequent = array[i];
            }
        }
        Console.WriteLine("Most frequent number: " + mostFrequent);
    }
}
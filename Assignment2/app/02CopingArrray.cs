namespace app1;
class CopyingArrays
{
    public void CopingArray()
    {
        int[] originalArray = new int[10];
        for (int i = 0; i < originalArray.Length; i++)
        {
            originalArray[i] = i * 10;
        }
        int[] newArray = new int[originalArray.Length];
        for (int i = 0; i < originalArray.Length; i++)
        {
            newArray[i] = originalArray[i];
        }
        Console.WriteLine("Original Array");
        for (int i = 0; i < originalArray.Length; i++)
        {
            Console.WriteLine(originalArray[i]);
        }
        Console.WriteLine("New Array");
        for (int i = 0; i < newArray.Length; i++)
        {
            Console.WriteLine(newArray[i]);
        }

    }
}

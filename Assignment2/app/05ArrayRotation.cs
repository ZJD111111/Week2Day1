namespace app1;

class ArrayRotations
{
    public void ArrayPotation()
    {
        Console.WriteLine("array:");
        int[] array = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        Console.WriteLine("k:");
        int k = int.Parse(Console.ReadLine());
        int n = array.Length;
        int[] sum = new int[n];
        for (int r = 1; r <= k; r++)
        {
            int[] rotatedArray = RotateArrayRight(array, r);
            for (int i = 0; i < n; i++)
            {
                sum[i] += rotatedArray[i];
            }
        }
        Console.WriteLine("Sum:");
        foreach (int element in sum)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }
    static int[] RotateArrayRight(int[] array, int k)
    {
        int n = array.Length;
        int[] rotatedArray = new int[n];
        for (int i = 0; i < n; i++)
        {
            int newIndex = (i + k) % n;
            rotatedArray[newIndex] = array[i];
        }
        return rotatedArray;
    }
}

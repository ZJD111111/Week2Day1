namespace app1;
class CountingLoops
{
    public void CountingLoop()
    {
        for (int i = 1; i <= 4; i++)
        {
            for (int j = 0; j <= 24; j += i)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
    }
}
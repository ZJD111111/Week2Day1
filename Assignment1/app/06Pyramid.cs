namespace app1;
class Pyramid
{
    public void printPyramid(int n)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                Console.Write(" ");
            }
            for (int j = 0; j < 1 + i * 2; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
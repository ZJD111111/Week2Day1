namespace app1;
class PrimeNumbers
{
    public void PrimeNumber(int startNum, int endNum)
    {
        int[] result = new int[endNum - startNum + 1];
        for (int number = startNum; number <= endNum; number++)
        {
            bool isPrime = true;
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
            {
                result[number - startNum] = number;
            }
        }
        foreach (int prime in result)
        {
            if (prime != 0)
            {
                Console.Write(prime + " ");
            }
        }
    }
}
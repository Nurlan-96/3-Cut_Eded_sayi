int numbers(int n, int m)
{
    int counter = 0;
    while (n < m)
    {
        if (n % 2 == 0)
        {
            counter++;
        }
        n++;
    }
    return counter;
}
Console.WriteLine(numbers(1,10));
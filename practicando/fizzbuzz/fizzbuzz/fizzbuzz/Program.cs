

for (int i = 1; i <= 100; i++)
{
    if (i % 3 ==0)
    {
        Console.WriteLine("FIZZ");
        if (i % 5 == 0)
        {
            Console.WriteLine("FIZZBUZZ");
        }

    }
    else if(i % 5 == 0)
    {
        Console.WriteLine("buzz");
    }else
    {
        Console.WriteLine("numero: " + i);
    }
}
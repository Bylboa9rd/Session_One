// Shows difference between break and continue, prints even numbers between 1 and 10

internal class BreakVSContinue
{
    public static void Main(string[] args)
    {
        for (int i = 0; i <= 10; i++)
        {

            if (i % 2 == 0)
            {
                Console.WriteLine($"{i} is an even number");
                continue;
            }

            if (i == 9)
            {
                break;
            }

        };




    }
}


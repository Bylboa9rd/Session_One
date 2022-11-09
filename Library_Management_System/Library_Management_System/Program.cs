//Program for a library management system which displays options of available books and their sections.
//options: c for C# books, o for .Net books, d for clean coding books, e for EFCore books
//if user enters a wrong value, showthem a message to try again
internal class LearningManagementSystem
{
    public static void TryAgain()
    {
        Console.Write(@"Would you like to try again? Enter Y for Yes or N for No.

Your response: ");
        string response = Console.ReadLine();
        response = response.ToUpper();

        if (response == "N")
        {
            Console.WriteLine("You are now exiting the library");
            return;
        }
        else if (response == "Y")
        {
            DaLibrary();
            TryAgain();
        }
        else
        {
            Console.WriteLine("You have entered a wrong input");
            TryAgain();
        }
    }
    public static void DaLibrary()
    {
        Console.WriteLine("This library is available to you for free. You can choose from any of the categories in the options below.");
        Console.WriteLine(@"Options:
                    Enter c for C# books,
                          o for .Net core books,
                          d for clean coding books, and
                          e for EFCore books");
        Console.Write("Your answer: ");
        switch (Console.ReadLine().ToUpper())
        {
            case "C":
                Console.WriteLine("You are now in the C# books section.");
                break;
            case "O":
                Console.WriteLine("You are now in the .Net Core books section.");
                break;
            case "D":
                Console.WriteLine("You are now in the clean coding books section.");
                break;
            case "E":
                Console.WriteLine("You are now in the EFCore books section.");
                break;
            default:
                Console.WriteLine("You have entered a wrong format. Please try again");
                break;
        }
    }
    public static void Main(string[] args)
    {
        DaLibrary();
        TryAgain();
    }
}
//Function that takes in dates as strings and returns the date a week after

class MyFunction
{

    public static void myFunction()
    {
        
        Console.Write("Enter a date (eg 9/11/2022) and we'll tell you the date after a week: ");
        DateTime date = DateTime.Parse(Console.ReadLine());

        DateTime weekAfter = date.AddDays(7);
        

        Console.WriteLine($"Seven days from {date.ToString()} is {weekAfter.ToString()} ");
    }
    public static void Main(string[] args)
    {
       myFunction();
    }
}
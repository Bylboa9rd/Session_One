//Implement a basic authentication system scope. user should be able to log in

class User
{
    public static void Main(string[] args)
    {
        List<string> person1 = new List<string>();

        Console.WriteLine("Choose a unique username and password for your account");
        Console.Write("Enter your full name (eg John Doe): ");
        string name = Console.ReadLine();

        Console.Write("Enter your unique password: ");
        string password = Console.ReadLine();

        if(!String.IsNullOrEmpty(name) && !String.IsNullOrEmpty(password))
        {
            person1.Add(name);
            person1.Add(password);
            Console.WriteLine("Registration was completed successfully");
        }
        else
        {
            Console.WriteLine("Wrong input format");
            Console.WriteLine("Registration was not successful. You are now exiting the program.");
            return;
        }

        Console.WriteLine("You are now being redirected to the log in page");
        Console.Write("Enter your username: ");
        string userName = Console.ReadLine();

        Console.Write("Enter your password: ");
        string userPassword = Console.ReadLine();  

        if(person1.Contains(userName) && person1.Contains(userPassword))
        {
            Console.WriteLine($"Welcome {userName}, you are now logged in.");
        }
        else
        {
            Console.WriteLine("Oops. Wrong username or password");
        }

    }
}


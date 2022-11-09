// Program that takes a string, transforms all but the last four characters into "#" and returns the new masked string

namespace StringHasher
{
 class Program
    {
        public static void Main(string[] args)
        {
            string word;
            string lastFour;
            int four = 4;

            Console.Write("Enter a word: ");
            word = Console.ReadLine();
            if (word.Length > four)
            {
                lastFour = word.Substring(word.Length - four);

                for (int i = 0; i < word.Length - four; i++)
                {
                    Console.Write("#");
                }

                Console.Write(lastFour);
            }
            else if (word.Length < four)
            {
                Console.WriteLine(word);
            }
            else
            {
             Console.WriteLine("Enter a valid input");
            }
        }
    }
}


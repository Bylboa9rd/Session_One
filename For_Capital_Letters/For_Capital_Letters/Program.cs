//Program that takes a string and returns an ordered array containing the indices of all capital letters in the string

internal class Program
{
    private static void Main(string[] args)
    {
        List<char> myOrderedArray = new List<char>();
        string? sentence;

        Console.Write("Enter a sentence: ");
        sentence = Console.ReadLine();
        char[] chars = sentence.ToCharArray();

        foreach(char ch in chars)
        {
            if (char.IsUpper(ch))
            {
                myOrderedArray.Add(ch);
                Console.WriteLine($"{ch} was found at index {sentence.IndexOf(ch)}");
                
            }
        }

        myOrderedArray.Sort();
        foreach (char c in myOrderedArray)
        {
            Console.Write(c);
        }
    }

}
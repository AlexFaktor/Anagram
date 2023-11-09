namespace Anagram
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Input: ");
            string line = Console.ReadLine();
            Console.WriteLine(LineConverter.AnagramWord(line));
        }
    }
}
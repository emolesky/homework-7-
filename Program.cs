namespace UniqueChar
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();

            Solution aSolution = new Solution();
            int index = aSolution.FirstUniqChar(input);

            if (index != -1)
            {
                Console.WriteLine($"The first non- repeating character is at index: {index}");

            }
            else
            {
                Console.WriteLine("Ther is no non- repeating character in the string.");
            }
        }
    }
}




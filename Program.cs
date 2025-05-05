namespace NumberOfSegments
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();

            Solution aSolution = new Solution();
            int segmentCount = aSolution.CountSegments(input);
            Console.WriteLine($"Number of segments: {segmentCount}"); 
        }
    }
}

namespace ballons
{
    public class Program
    {
        static void Main(string[] args)
        {
            string text = "loonbalxballpoon";

            Solution solution = new Solution();
            int result = solution.MaxNumberOfBaloons(text);

            Console.WriteLine($"{result}");
        }
    }
}

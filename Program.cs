namespace Robot
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Solution aSolution = new Solution();


            string moves = "UDLR";
            bool result = aSolution.JudgeCircle(moves);
            Console.WriteLine(result);   
        }
    }
}

using System.Security.Cryptography.X509Certificates;

namespace Difference
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            string s = "abcd";
            string t = "abcde";
            Solution aSolution = new Solution();
        

            char result = aSolution.FindTheDifference(s, t);

            Console.WriteLine(result);
           
        }
    }
}

namespace Merge
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = [0];
            int m = 0;
            int[] nums2 = [1];
            int n = 1;

            Solution solution = new Solution();
            solution.Merge(nums1, m, nums2, n);

            Console.WriteLine("Merged array: " + string.Join(", ", nums1));
        }
    }
}

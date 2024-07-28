namespace _1920._Build_Array_from_Permutation
{
    public class Program
    {
        public static int[] BuildArray(int[] nums)
        {
            int[] ans = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
           
            {
                ans[i] = nums[nums[i]];
            }
            return ans;
        }
        static void Main(string[] args)
        {
            int[] nums = [5, 0, 1, 2, 3, 4];

            int[] ans = Program.BuildArray(nums);
            foreach (int i in ans)
            {
                Console.WriteLine(i);
            }
        }
    }
}

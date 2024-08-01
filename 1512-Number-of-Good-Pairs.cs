public class Solution {
   public int NumIdenticalPairs(int[] nums)
{
    int Pairscounter = 0;
    for (int i =0; i<nums.Length; i++)
    {
        for(int j=nums.Length -1 ; j>=0; j--)
        {
            if (nums[j] == nums[i] && j < i)
            {
                Pairscounter++;
            }
        }
    }
    return Pairscounter;
}
}
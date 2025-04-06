public class Solution {
   public int SearchInsert(int[] nums, int target)
{
    int index = 0;

    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] == target)
        {
            index = i;
            break;
        }
        if (i + 1 < nums.Length &&  target > nums[i] && target < nums[i+1])
        {
            index = i + 1;
            break;
        }
        if (i == nums.Length -1 && target > nums[i])
        {
            index = nums.Length;
        }

    }
    return index;
}
}
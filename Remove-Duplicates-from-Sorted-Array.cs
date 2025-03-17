public class Solution {
    public int RemoveDuplicates(int[] nums)
{
  //refers to the unique number index
 //as index 0 is the first time to see the element , so we check if the after is unique or duplicate
//unique  nums<= l كل الى قبل 
    int l = 1;
    for (int r = 1; r < nums.Length; r++)
    {
        if (nums[r] != nums[r - 1]) // means we have to copy the unique element on the left
        {
            // unique يحط الرقم الجديد بعد اخر رقم
            nums[l] = nums[r];
            l++;
        }
        
    }
    
    return l;

}
}
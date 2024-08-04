public class Solution {
         public int SumOfUnique(int[] nums)
 {
     Dictionary<int ,int> UniqueNums = new Dictionary<int, int>();
     int UniqueNumsSum = 0;

     foreach (int num in nums)
     {
         if (!UniqueNums.ContainsKey(num))
         {
             UniqueNums[num] = 1;
         }
         else
             UniqueNums[num]++;
     }

   
     foreach(var item in UniqueNums)
     {
         if(item.Value == 1)
             UniqueNumsSum += item.Key;
     }

     return UniqueNumsSum;
 }
}
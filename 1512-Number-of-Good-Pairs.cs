public class Solution {
  public int NumIdenticalPairs(int[] nums)
 { 
     Dictionary<int,int> NumPairs = new Dictionary<int,int>();
     int Pairscounter = 0;
     foreach (int item in nums)
     {

           //New occurs of Item ?
            //How many times the Item appears before ?
            //Num of previous occurs  * new occurs ==> Num of Pairs can this item make         
          int count = NumPairs.GetValueOrDefault(item, 0);
          Pairscounter += count;
          NumPairs[item] = count+1;
         
     }

     return Pairscounter;
 }
}
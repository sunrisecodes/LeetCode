public class Solution {
     public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
  {
      IList<bool> result = new List<bool>();
      int MaxCandies = candies.Max();
      foreach (var cand in candies)
      {
          result.Add(cand + extraCandies >= MaxCandies);
      }

      return result;
  }
}
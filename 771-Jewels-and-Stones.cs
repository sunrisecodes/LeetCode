public class Solution {
            public int NumJewelsInStones(string jewels, string stones)
        {
            int output = 0;
            Dictionary<int, int> StonesOccurs = new Dictionary<int, int>();

            foreach (var item in stones)
            {
                if (StonesOccurs.ContainsKey(item))
                {
                    StonesOccurs[item]++;
                }
                else
                {
                    StonesOccurs.Add(item, 1);
                }
            }

            foreach (var item in jewels)
            {
                if (StonesOccurs.ContainsKey(item))
                {
                    output += StonesOccurs[item];
                }
            }

            return output;
        }

}
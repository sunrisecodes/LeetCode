public class Solution {
  public string MergeAlternately(string word1, string word2)
        {
            string MergedStr = string.Empty;  

            int i = 0;
            int j = 0;

            while (i < word1.Length && j < word2.Length)
            {
               
                    MergedStr += word1[i];
                    MergedStr += word2[j];
                    i++;j++;
                
               
            }

            if( i < word1.Length)
            {
                MergedStr += word1.Substring(word2.Length);

            }

            if (j < word2.Length)
            {
                MergedStr += word2.Substring(word1.Length);

            }

            return MergedStr;
        }
}
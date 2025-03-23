public class Solution {
          public int StrStr(string haystack, string needle)
 {
     int i = 0, j = 0;
     while (i < haystack.Length)
     {
         if (haystack[i] == needle[j])
         {
             int start = i;
             while (i < haystack.Length && j < needle.Length && haystack[i] == needle[j] )
             {
                 i++;
                 j++;
             }
             if (j == needle.Length) return start;
             else
                 j = 0;
                 i = start;
         }
         i++;
     }
     return -1;

 }

}
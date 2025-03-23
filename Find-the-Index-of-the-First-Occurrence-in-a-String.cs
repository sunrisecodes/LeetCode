public class Solution {
           public int StrStr(string haystack, string needle)
        {
            int found = -1;
            int i = 0, j = 0;
            while (i < haystack.Length)
            {
                if (haystack[i] == needle[j])
                {
                    int start = i;
                    i++;
                    j++;
                    while (i < haystack.Length && j < needle.Length)
                    {
                        if (haystack[i] != needle[j])
                            break;

                        i++;
                        j++;
                    }
                    if (j == needle.Length)
                    {
                        found = start;
                        return found;
                    }
                    else
                        j = 0;
                        i = start;
                }
                i++;
            }
            return found;

        }


}
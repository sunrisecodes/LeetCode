public class Solution
{
    public bool ArrayStringsAreEqual(string[] word1, string[] word2)
    {
        string FullString1 = string.Concat(word1);
        string FullString2 = string.Concat(word2);

       

        return FullString1.Equals(FullString2);
    }

}
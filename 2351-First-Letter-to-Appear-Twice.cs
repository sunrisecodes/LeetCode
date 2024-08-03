public class Solution 
{
    public char RepeatedCharacter(string s)
 {
    Dictionary<char,int> dict = new Dictionary<char,int>();
    Char RepeatedCh  = new Char();
    foreach (char ch in s)
    {
        if (dict.ContainsKey(ch))
        {
            RepeatedCh = ch;
            return RepeatedCh;
        }

        dict[ch] = 1;
           

    }

    return RepeatedCh;
  } 
}
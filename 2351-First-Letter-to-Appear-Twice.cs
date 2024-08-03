public class Solution 
{
    
     public char RepeatedCharacter(string s)
 {
     HashSet<char> Characters = new HashSet<char>();
     foreach (char ch in s)
     {
         if (Characters.Contains(ch))
             return ch;
         
         
         Characters.Add(ch);
         
     }

     return ' ';

 }
}
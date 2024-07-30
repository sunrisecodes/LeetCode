public class Solution
{

private readonly string[] MorseCodes = [".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.."];


 public int UniqueMorseRepresentations(string[] words)
 {
     
     HashSet<string> Transformations = new HashSet<string>();
     foreach (var word in words)
     {
         StringBuilder sb = new StringBuilder();
         foreach(char ch in word)
         {
             
             sb.Append(MorseCodes[ch-'a']);
         }
         Transformations.Add(sb.ToString());
     }

     return Transformations.Count;
 }


}
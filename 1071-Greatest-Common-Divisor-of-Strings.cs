public class Solution {

    //Find GCD for strings length 
    public int GCD(int num1 , int num2)
  {
    int MinLen = Math.Min(num1, num2);
    int GCDNum = 0;
    for (int i = 1; i <= MinLen; i++)
    {
        if(num1 % i == 0 && num2 % i == 0)
            GCDNum = i;
    }
    return GCDNum;
  }


public string GcdOfStrings(string str1, string str2)
{
    if ((str1 + str2).Equals(str2 + str1))
    {
        string GCDStr = str1.Substring(0, GCD(str1.Length, str2.Length));

        return GCDStr;
    }
    
    return "";
  
}
}
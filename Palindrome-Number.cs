public class Solution {
 public bool IsPalindrome(int x)
    {
        int number = x;
        int reversed = 0;

        while (x > 0)
        {
        //get last digit in the number (%)
            int digit = x % 10;
        //to append the digit on the left *10, as it *10 shit the digit to the left like 5 * 10 = 50
            reversed = reversed* 10 + digit;
        //remove last digit from the number
            x /= 10;
        }
        if(number == reversed)
            return true;

        return false;
    }
}
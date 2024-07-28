public class Solution {
    public int MinimumOperations(int[] nums) {
        int operations = 0;

        foreach(int num in nums){
            if(num % 3 != 0)
            operations +=1;
        }

        return operations;
    }
}
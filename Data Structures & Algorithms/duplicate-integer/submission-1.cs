public class Solution {
    public bool hasDuplicate(int[] nums) {
        int n = nums.Length;
        HashSet<int> set = new HashSet<int>();
        foreach(int num in nums){
            if(set.Contains(num)) return true;
            set.Add(num);
        }

        return false;
    }
    





}
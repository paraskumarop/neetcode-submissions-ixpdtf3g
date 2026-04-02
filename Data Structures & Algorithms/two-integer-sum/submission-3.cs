public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        // [6,  5,3,4]  target = 7
                //   i j          
        int n = nums.Length;
        for(int i = 0 ; i < n ; i++){
            for(int j = i+1; j< n ; j++){
                if(nums[i] + nums[j] == target) return new int[2]{i,j};
            }
        }

        return new int[0];
    }
}

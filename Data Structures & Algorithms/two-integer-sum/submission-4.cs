public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        // [6,  5,3,4]  target = 7
                //   i j          
        int n = nums.Length;
        Dictionary<int , int> map = new Dictionary<int, int>();

        for(int i = 0 ;i < n ; i++){
            int requiredSecond = target - nums[i] ;
            if(map.ContainsKey(requiredSecond)) return new int[2]{map[requiredSecond],i};
            map[nums[i]] = i;
        }

        return new int[0];
    }
}

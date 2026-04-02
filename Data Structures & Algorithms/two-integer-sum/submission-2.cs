public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        int n = nums.Length;
        
        Dictionary<int , int> dictionary = new Dictionary<int, int>();

        for(int i = 0 ;i < n ;i++){
            dictionary[nums[i]] = i;
        }

        for(int i = 0 ; i < n ; i++ ){
            if(dictionary.ContainsKey(target - nums[i])){
                int j = dictionary[target - nums[i]];
                if(j != i) 
                    return new int[] { i, j };
            }
        }

        return new int[0];
    }
}

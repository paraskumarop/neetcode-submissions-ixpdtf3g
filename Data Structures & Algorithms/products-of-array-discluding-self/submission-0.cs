public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int n = nums.Length;
        int [] leftMultiply = new int [n];
        int [] rightMultiply = new int[n];
int [] ans = new int [n];
        for(int i = 0 ; i < n ; i++){
            if(i == 0) leftMultiply[i] = nums[i];
            else leftMultiply[i] = leftMultiply[i -1 ] * nums[i];
        }
        for(int i = n - 1 ; i >= 0 ; i--){
            if(i == n - 1) rightMultiply[i] = nums[i];
            else rightMultiply[i] =rightMultiply[i+ 1] *  nums[i];
        }


        for(int i = 0 ; i < n ; i++){
            if(i == 0 ) {
                ans[i] = rightMultiply[i + 1];
                continue;
            }
            else if(i == n - 1) {
                ans[i] = leftMultiply[i - 1];
            }
            else {
                ans[i] = leftMultiply[i-1] * rightMultiply[i+1];
            }
        }

    return ans;

        
    }
}

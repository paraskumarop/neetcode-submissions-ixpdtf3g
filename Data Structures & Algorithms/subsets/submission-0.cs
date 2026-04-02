public class Solution {
    public List<List<int>> Subsets(int[] nums) {
        List<List<int>> ans = new List<List<int>>();
        int n = nums.Length;
        List<int> current = new List<int>();
        totalSubsets(0,n,nums,ans,current);
        return ans;
    }

    public void totalSubsets(int i ,int n, int [] nums, List<List<int>> ans,List<int> current){
        if(i == n) {
            ans.Add(new List<int> (current));   
            return;
        }

        current.Add(nums[i]);
        totalSubsets(i+1,n,nums,ans,current);
        current.RemoveAt(current.Count -1);
        totalSubsets(i+1 , n , nums,ans, current);
        // current.RemoveAt(current.Count - 1);
    }
}

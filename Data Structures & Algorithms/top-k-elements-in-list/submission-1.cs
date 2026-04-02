public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        int [] ans = new int [k];
        var frequency = new Dictionary<int ,int>();
        var map = new PriorityQueue<int ,int>(); 
        foreach(int num in nums){
                if(!frequency.ContainsKey(num)){
                        frequency.Add(num,0);
                }
                frequency[num]++;
        }

        foreach(var item in frequency){
                map.Enqueue(item.Key , item.Value);
                if(map.Count > k) map.Dequeue();
        }

        for(int i = k - 1; i >= 0 ; i--){
                ans[i] = map.Dequeue();
        }

        return ans;

    }
}

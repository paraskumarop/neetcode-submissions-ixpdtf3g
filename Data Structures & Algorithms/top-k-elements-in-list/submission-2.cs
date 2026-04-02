public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var frequency = new Dictionary<int,int>();
        var pq = new PriorityQueue<int,int>();
        int [] ans = new int[k]; 
        foreach(int num in nums){
                if(!frequency.ContainsKey(num)){
                        frequency.Add(num,0);
                }
                frequency[num]++;
        }

        foreach(var item in frequency){
                pq.Enqueue(item.Key,item.Value);
                if(pq.Count > k) pq.Dequeue();
        }

        for(int i = 0 ; i < k ; i++){
                ans[i] = pq.Dequeue();
        }

        return ans;
    }
}

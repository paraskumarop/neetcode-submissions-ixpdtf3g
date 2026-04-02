public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        int [] ans = new int[k];
        Dictionary<int ,int> freq = new Dictionary<int,int>();

        foreach(int num in nums){
            if(!freq.ContainsKey(num)){
                freq.Add(num,0);
            }
            freq[num] += 1;
        }

        PriorityQueue<int, int> pq = new PriorityQueue<int,int>(Comparer<int>.Create((a,b) => b.CompareTo(a)));
        
        foreach(var item in freq){
            pq.Enqueue(item.Key,item.Value);
        }
        int i = 0;
        while(k > 0) {
           ans[i++] = pq.Dequeue();
           k--;
        }

        return ans;
    }
}

public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        int n = nums.Length;
        var frequency = new Dictionary<int,int>();
        // var pq = new PriorityQueue<int,int>();
        List<int> [] listArray = new List<int>[n+1];

        int [] ans = new int[k]; 
        foreach(int num in nums){
                if(!frequency.ContainsKey(num)){
                        frequency.Add(num,0);
                }
                frequency[num]++;
        }

        foreach(var item in frequency){
                if(listArray[item.Value] == null){
                        listArray[item.Value] = new List<int>();
                }

                listArray[item.Value].Add(item.Key);
        }
        k--;
        for(int i = n ; i >= 0 ; i--){
                if(listArray[i] != null){

                        for(int j = 0 ; j < listArray[i].Count; j++ ){
                                ans[k] = listArray[i][j];
                                if(k == 0) return ans;
                                k--;
                        }
                }
        }

        return ans;
    }

    

}

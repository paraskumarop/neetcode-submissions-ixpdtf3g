public class Solution {

    public string Encode(IList<string> strs) {
        
        int n = strs.Count;
        if(n == 0) return null;
        StringBuilder resultStr = new StringBuilder();
        for(int i = 0 ; i < n ; i++){
            resultStr.Append(strs[i]);
            if(i != n - 1)
                resultStr.Append("/n");
        }

        return resultStr.ToString();
    }

    public List<string> Decode(string s) {
        if(s == null) return new List<string>();
        string [] decodedArray = s.Split("/n");

        return decodedArray.ToList();
    }
}

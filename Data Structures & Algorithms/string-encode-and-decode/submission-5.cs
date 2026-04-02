public class Solution {

    public string Encode(IList<string> strs) {
        StringBuilder ansString = new StringBuilder();
        foreach(string str in strs){
            ansString.Append(str.Length).Append("#").Append(str);
        }

        return ansString.ToString();

    }

    public List<string> Decode(string s) {
        
        List<string> ans = new List<string>();
        for(int i = 0 ; i < s.Length; i++){
            int j = i;
            while(s[j] != '#'){
                j++;
            }
            int length = int.Parse(s.Substring(i,j-i));
            
            string word = s.Substring(j+1,length);
            
            ans.Add(word);

            j = j + length ;
            i = j;
        }

        return ans;
    }
}

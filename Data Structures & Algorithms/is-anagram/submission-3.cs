public class Solution {
    public bool IsAnagram(string s, string t) {
        int n = s.Length , m = t.Length;
        int [] freqofS = new int[26];
        int [] freqofT = new int[26];
        int i = 0;
        if(n != m) return false;
        while(i < n && i < m){
            freqofS[s[i] - 'a']++;
            freqofT[t[i] - 'a']++;
            i++;
        }

        for(int j = 0 ; j < 26 ; j++){
            if(freqofS[j] != freqofT[j]) return false;
        }
        
        return true;
    }
}

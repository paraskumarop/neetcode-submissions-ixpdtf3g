public class Solution {
    public bool IsAnagram(string s, string t) {
        int n = s.Length, m = t.Length;

        int [] freqofS = new int[26]; // constant space
        int [] freqofT = new int[26]; // constant space
        int i = 0 ;
       
    //    FreqofS[17] = 1;
    //    FreqofT[17] = 0; 
        while(i < n && i < m){
            freqofS[s[i] - 'a']++;
            freqofT[t[i++] - 'a']++;
        }

        while(i < n){
            freqofS[s[i++] - 'a']++;
        }
        while(i < m){
            freqofT[t[i++] - 'a']++;
        }

        for(int j = 0 ; j < 26; j++){
            if(freqofS[j] != freqofT[j] ) return false;
        }

        return true;
    }
}

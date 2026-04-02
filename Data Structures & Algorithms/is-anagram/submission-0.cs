public class Solution {
    public bool IsAnagram(string s, string t) {
        int [] freq1 = new int [26];
        int [] freq2 = new int [26];
        int n = s.Length , m = t.Length;
        int i = 0;
        while(i < n && i < m){
            freq1[s[i] - 'a']++;
            freq2[t[i++] - 'a']++;
        }
        while(i < n){
            freq1[s[i++] - 'a']++;
        }
        while(i < m){
            freq2[t[i++] - 'a']++;
        }


        for(int j = 0 ; j < 26; j++){
            if(freq1[j] != freq2[j]) return false;
        }

        return true;

    }
}

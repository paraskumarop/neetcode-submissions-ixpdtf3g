public class Solution {
    public int ScoreOfString(string s) {
        int score = 0 , n = s.Length;
        for(int i = 1 ; i < n; i++){
            score += Math.Abs(s[i] - s[i-1]);
        }
        return score;
    }
}
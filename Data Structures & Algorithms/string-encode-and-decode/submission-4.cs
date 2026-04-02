public class Solution {

    public string Encode(IList<string> strs) {
        StringBuilder resultStr = new StringBuilder();
        
        foreach (string s in strs) {
            // Append the length, a '#' delimiter, and the string itself
            resultStr.Append(s.Length).Append('#').Append(s);
        }

        return resultStr.ToString();
    }

    public List<string> Decode(string s) {
        List<string> decodedList = new List<string>();
        
        int i = 0 ;

        while(i < s.Length){
            int j = i;
            while (s[j] != '#') {
                j++;
            }
            int length = int.Parse(s.Substring(i, j - i));
            int stringStart = j + 1;
            decodedList.Add(s.Substring(stringStart, length));
            i = stringStart + length;
        }
        return decodedList;
    }
}

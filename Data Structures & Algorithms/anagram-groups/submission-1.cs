public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {

        Dictionary<string , List<string>> map = new Dictionary<string , List<string>>();

        foreach(string s in strs){
            char [] charArray = s.ToCharArray();
            Array.Sort(charArray);
            string sortedString = new String(charArray);
            if(!map.ContainsKey(sortedString)){
                map[sortedString] = new List<string>();
            }
            map[sortedString].Add(s);
        }

        return new List<List<string>>(map.Values);

    }
}

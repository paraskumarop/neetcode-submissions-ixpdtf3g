public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
    //   Array.Sort(strs);

      Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();

      foreach(string str in strs){
        char[] count = new char[26];


        foreach(char c in str){
            count[c - 'a']++;
        }
         
         string key = new string(count);
         if(!map.ContainsKey(key) ) {
            map[key] = new List<string>();
         }
         map[key].Add(str);
      }

     return new List<List<string>>(map.Values);

    }
}

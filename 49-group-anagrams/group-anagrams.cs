public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        Dictionary<string,List<string>> anagrams = new Dictionary<string,List<string>>();

        foreach(var str in strs)
        {
            string key = string.Concat(str.OrderBy(c => c));
            if(!anagrams.ContainsKey(key))
            {
                anagrams[key] = new List<string>();
            }
            anagrams[key].Add(str);
        }

        return anagrams.Values.ToList<IList<string>>();
    }
}
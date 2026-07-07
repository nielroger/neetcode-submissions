public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        
        var result = new List<List<string>>();
        var dict = new Dictionary<string, List<string>>();
        foreach(var str in strs)
        {
            var charArray = str.ToCharArray();
            Array.Sort(charArray);
            string sorted = new string(charArray);
            if(!dict.ContainsKey(sorted))
            {
                dict.Add(sorted, new List<string>(){str});
            }
            else
            {
                dict[sorted].Add(str);
            }
        }

        foreach(var item in dict)
        {
            result.Add(item.Value);
        }
        return result;
    }
}

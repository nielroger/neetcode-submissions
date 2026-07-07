public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        
        var dict = new Dictionary<string, List<string>>();
        var result = new List<List<string>>();
        foreach(var item in strs)
        {
            var arr = item.ToCharArray();
            Array.Sort(arr);
            var sorted = new string(arr);

            if(dict.ContainsKey(sorted))
            
                dict[sorted].Add(item);
            else
                dict[sorted] = new List<string> { item };
        }

        foreach(var item in dict)
        {
            result.Add(item.Value);
        }
        return result;
    }
}
public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var res = new List<List<string>>();
        if(strs.Length == 0) return res;

        var dict = new Dictionary<string, List<string>>();

        foreach(var str in strs)
        {
            char[] chars = str.ToCharArray();
            Array.Sort(chars);
            string sorted = new string(chars);
            if(!dict.ContainsKey(sorted))        
            {
                dict.Add(sorted, new List<string>());
            }
            dict[sorted].Add(str);
        }

        foreach(var item in dict)
        {
            res.Add(item.Value);
        }

        return res;
    }
}

public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var result =  new List<List<string>>();

        var dict = new Dictionary<string, List<string>>();
        foreach(var str in strs)
        {
            char[] chars = str.ToCharArray();
            Array.Sort(chars);
            var sorted = new string(chars);
            if(!dict.ContainsKey(sorted))
            {
                dict.Add(sorted, new List<string>());
            }

            dict[sorted].Add(str);
        }

        foreach(var item in dict)
        {
            result.Add(item.Value);
        }

        return result;
    }
}

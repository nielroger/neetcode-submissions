public class Solution {

    public string Encode(IList<string> strs) {
        var result = new StringBuilder();

        foreach(var str in strs)
        {
            result.Append($"{str.Length}#{str}");
        }
        return result.ToString();
    }

    public List<string> Decode(string s) {
        
        var result = new List<string>();
        int i = 0;
        while(i < s.Length)
        {
            int j = s.IndexOf('#', i);
            int length = int.Parse(s.Substring(i, j - i));
            result.Add(s.Substring(j + 1, length));
            i = j + 1 + length;
        }

        return result;
   }
}
public class Solution {

    public string Encode(IList<string> strs) {
        
        var sb = new StringBuilder();

        foreach(var str in strs)
        {
            sb.Append($"{str.Length}#{str}");
        }

        return sb.ToString();
    }

    public List<string> Decode(string s) {

        var result = new List<string>();
        int i = 0;
        while(i < s.Length)
        {
            int index = s.IndexOf('#', i);
            int length = int.Parse(s.Substring(i, index - i));
            var str = s.Substring(index + 1, length);
            result.Add(str);
            i = index + length + 1;
        }
        return result;
   }
}

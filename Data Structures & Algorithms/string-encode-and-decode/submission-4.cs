public class Solution {

    public string Encode(IList<string> strs) {
        
        var str = new StringBuilder();
        foreach(var item in strs)
        {
            str.Append($"{item.Length}#{item}");
        }
        return str.ToString();
    }

    public List<string> Decode(string s) {

        int i = 0;
        var list = new List<string>();
        while(i < s.Length)
        {
            int hashIndex = s.IndexOf('#', i);
            int length = int.Parse(s.Substring(i, hashIndex - i));
            var str = s.Substring(hashIndex + 1, length);
            list.Add(str);
            i = hashIndex + 1 + length;
        }

        return list;
   }
}
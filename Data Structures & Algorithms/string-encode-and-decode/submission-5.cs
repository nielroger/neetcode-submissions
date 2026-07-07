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

        var list = new List<string>();      
        int index = 0;  
        while(index < s.Length)
        {
            int hashIndex = s.IndexOf('#', index);
            int length = int.Parse(s.Substring(index, hashIndex - index));
            var str = s.Substring(hashIndex + 1, length);
            list.Add(str);
            index = hashIndex + length + 1;
        }

        return list;
   }
}

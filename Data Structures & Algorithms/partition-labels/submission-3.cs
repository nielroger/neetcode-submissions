public class Solution {
    public List<int> PartitionLabels(string s) {
        
        var map =  new int[26];

        for(int i = 0; i < s.Length; i++)
        {
            map[s[i] - 'a'] = i;
        }

        int start = 0;
        int end = 0;
        var result = new List<int>();

        for(int i = 0 ; i < s.Length; i++)
        {
            end = Math.Max(end, map[s[i] - 'a']);
            if(i == end)
            {
                result.Add( i - start + 1);
                start = i + 1;
            }
        }

        return result;
    }
}

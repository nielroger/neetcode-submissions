public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        
        var count = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++)
        {
            if (!count.ContainsKey(nums[i])) count[nums[i]] = 0;
            count[nums[i]]++;
        }

        var freq = new List<int>[nums.Length + 1];
        for(int i = 0; i < freq.Length; i++)
        {
            freq[i] = new List<int>();
        }

        foreach(var item in count)
        {
            freq[item.Value].Add(item.Key);
        }

        var result = new List<int>();
        for(int i = freq.Length -1; i >= 0; i--)
        {
            foreach(var item in freq[i])
            {
                result.Add(item);
                if(result.Count == k) return result.ToArray();
            }
        }

        return result.ToArray();
    }
}

public class Solution {
    public int[] SortArray(int[] nums) {
        
        int[] freq = new int[100001];

        foreach(var num in nums)
        {
            freq[num + 50000]++;
        }

        var result = new int[nums.Length];
        
        int curr = 0;
        for(int i = 0; i < freq.Length; i++)
        {
            while(freq[i] > 0)
            {
                freq[i]--;
                result[curr++] = i - 50000;
            }
        }

        return result;
    }
}
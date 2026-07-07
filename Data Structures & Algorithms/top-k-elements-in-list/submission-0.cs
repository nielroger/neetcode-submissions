public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        
        var map = new SortedDictionary<int, int>();

        foreach(var num in nums)
        {
            if(!map.ContainsKey(num))
                map.Add(num, 1);
            else
                map[num]++;
        }

        var sortedList = map.OrderByDescending(x => x.Value).ToList();
        var result =  new int[k];
        for(int i = 0; i < k; i++)
        {
            result[i] = sortedList[i].Key;
        }

        return result;
    }
}

public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        
        var dict = new SortedDictionary<int , int>();

        foreach(var num in nums)
        {
            if(!dict.ContainsKey(num))
            {
                dict.Add(num, 0);
            }
            dict[num]++;
        }


        var sortedList = dict.OrderByDescending(x => x.Value).ToList();
        var res = new int[k];
        for(int i = 0; i < k; i++)
        {
            res[i] = sortedList[i].Key;
        }

        return res;
    }
}
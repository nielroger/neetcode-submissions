public class Solution {
    public bool IsNStraightHand(int[] hand, int groupSize) {
        if (hand.Length % groupSize != 0) return false;
        var dict = new SortedDictionary<int, int>();

        foreach(var item in hand)
        {
            if (dict.ContainsKey(item)) dict[item]++;
            else dict[item] = 1;
        }

        foreach(var key in dict.Keys.ToList())
        {
            if (dict[key] > 0)
            {
                int count = dict[key];
                for(int j = 0; j < groupSize; j++)
                {
                    if (!dict.ContainsKey(key + j) || dict[key + j] < count)
                        return false;
                    dict[key + j] -= count;
                }
            }
        }
        return true;
    }
}
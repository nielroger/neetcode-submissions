public class Solution {
    public int[] SortArray(int[] nums) {
        
        var q = new PriorityQueue<int, int>();
        foreach(var num in nums)
        {
            q.Enqueue(num, num);
        }

        var result= new int[nums.Length];
        int curr = 0;
        while(q.Count > 0)
        {
            result[curr] = q.Dequeue();
            curr++;
        }

        return result;
    }
}
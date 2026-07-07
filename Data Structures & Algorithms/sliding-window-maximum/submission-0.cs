public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        
        int n = nums.Length;
        var res =  new int[n - k + 1];

        var deque = new LinkedList<int>();
        for(int i = 0; i < n; i++)
        {
            while(deque.Count > 0 && deque.First.Value < i - k + 1)
            {
                deque.RemoveFirst();
            }

            while(deque.Count > 0 && nums[deque.Last.Value] <= nums[i])
            {
                deque.RemoveLast();
            }

            deque.AddLast(i);

            if(i >= k - 1)
                res[i - k + 1] = nums[deque.First.Value];
        }

        return res;
    }
}

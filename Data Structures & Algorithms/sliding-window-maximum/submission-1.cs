public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        

        var dequeue = new LinkedList<int>();

        var res =  new int[nums.Length - k + 1];

        for(int right = 0; right < nums.Length; right++)
        {
            while(dequeue.Count > 0 && dequeue.First.Value < right - k + 1)
            {
                dequeue.RemoveFirst();
            }

            while(dequeue.Count > 0 && nums[dequeue.Last.Value] <= nums[right])
            {
                dequeue.RemoveLast();
            }

            dequeue.AddLast(right);

            if(right >= k - 1)
            {
                res[right - k + 1] = nums[dequeue.First.Value];
            }
        }    

        return res;
    }
}

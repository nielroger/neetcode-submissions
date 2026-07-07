public class Solution {
    public int FindDuplicate(int[] nums) {
        // Start at indices, not values
        int slow = 0;
        int fast = 0;

        // Phase 1: Detect cycle
        do {
            slow = nums[slow];
            fast = nums[nums[fast]];
        } while (slow != fast);

        // Phase 2: Find entrance
        slow = 0;
        while (slow != fast) {
            slow = nums[slow];
            fast = nums[fast];
        }

        return slow;
    }
}
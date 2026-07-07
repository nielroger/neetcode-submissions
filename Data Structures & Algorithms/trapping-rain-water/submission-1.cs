public class Solution {
    public int Trap(int[] height) {
        
        int left = 0;
        int right = height.Length - 1;
        int water = 0;
        int leftMax = height[left];
        int rightMax = height[right];
        while(left < right)
        {
            if(leftMax < rightMax)
            {
                left++;
                leftMax = Math.Max(leftMax, height[left]);
                water += leftMax - height[left];
            }
            else
            {
                right--;
                rightMax = Math.Max(rightMax, height[right]);
                water += rightMax - height[right];
            }
        }

        return water;
    }
}

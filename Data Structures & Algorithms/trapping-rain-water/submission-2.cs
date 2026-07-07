public class Solution {
    public int Trap(int[] height) {
        
        int left = 0;
        int right = height.Length - 1;

        int leftMax = height[left];
        int rightMax = height[right];
        int result = 0;
        while(left < right)
        {
            if(leftMax < rightMax)
            {
                left++;
                leftMax = Math.Max(leftMax, height[left]);
                result += leftMax - height[left];
            }
            else
            {
                right--;
                rightMax = Math.Max(rightMax, height[right]);
                result += rightMax - height[right];
            }
        }
        return result;
    }
}
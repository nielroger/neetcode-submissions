public class Solution {
    public int MaxArea(int[] heights) {
        
        int maxArea = 0;

        int left = 0;
        int right = heights.Length - 1;
        
        while(left < right)
        {
            var leftMax = heights[left];
            var rightMax = heights[right];
            maxArea = Math.Max(maxArea, Math.Min(leftMax, rightMax) * (right - left));
            if(leftMax > rightMax)
            {
                right--;
            }            
            else
            {
                left++;
            }
        }

        return maxArea;
    }
}

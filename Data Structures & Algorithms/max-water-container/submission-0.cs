public class Solution {
    public int MaxArea(int[] heights) {
        
        int left = 0;
        int right = heights.Length - 1;
        
        int maxArea = 0;

        while(left < right)
        {

            int leftMax = heights[left];
            int rightMax = heights[right];    
            maxArea = Math.Max(maxArea, Math.Min(leftMax, rightMax) * (right - left));

            if(leftMax < rightMax)
            {
                left++;
            }
            else
            {
                right--;
            }

        }

        return maxArea;
    }
}
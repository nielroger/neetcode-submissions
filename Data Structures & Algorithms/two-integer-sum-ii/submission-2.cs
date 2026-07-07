public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        
        var left = 0;
        var right = numbers.Length - 1;

        while(left < right)
        {
            if(numbers[left] + numbers[right] == target)
            {
                return new int[2]{left + 1, right + 1};
            }
            else if(numbers[left] + numbers[right] > target)
            {
                right--;
            }
            else
            {
                left++;
            }
        }
        return new int[2]{-1,-1};
    }
}

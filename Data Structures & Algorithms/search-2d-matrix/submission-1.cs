public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        
        var m = matrix.Length;
        var n = matrix[0].Length;

        var left = 0;
        var right = m * n - 1;

        while(left <= right)
        {
            var mid = left + (right -left)/2;

            var val = matrix[mid/n][mid%n];

            if(val == target)
                return true;

            else
            {
                if(val < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
        }



        return false;
    }
}

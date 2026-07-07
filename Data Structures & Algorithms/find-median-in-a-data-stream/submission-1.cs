public class MedianFinder {
    private List<int> nums;

    public MedianFinder() {
        nums = new List<int>();
    }
    
    public void AddNum(int num) {
        int index = nums.BinarySearch(num);
        if (index < 0) index = ~index;
        nums.Insert(index, num);
    }
    
    public double FindMedian() {
        int n = nums.Count;
        if (n % 2 == 1) {
            return (double)nums[n / 2];
        } else {
            return (nums[n / 2 - 1] + nums[n / 2]) / 2.0;
        }
    }
}
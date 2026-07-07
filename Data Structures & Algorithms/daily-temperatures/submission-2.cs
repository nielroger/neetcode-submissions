public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        
        var stk = new Stack<int>();
        var result = new int[temperatures.Length];

        for(int i = 0; i < temperatures.Length; i++)
        {
            while(stk.Count > 0 && temperatures[stk.Peek()] < temperatures[i])
            {
                int preIndex = stk.Pop();
                result[preIndex] = i - preIndex;
            }
            stk.Push(i);
        }

        return result;
    }
}

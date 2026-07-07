public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        
        var stk = new Stack<int>();
        var result = new int[temperatures.Length];

        for(int i =0; i < temperatures.Length; i++)
        {
            while(stk.Count > 0 && temperatures[i] > temperatures[stk.Peek()])
            {
                var prevIndex = stk.Pop();
                result[prevIndex] = i - prevIndex;
            }

            stk.Push(i);
        }

        return result;
    }
}

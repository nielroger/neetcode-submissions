public class Solution {
    public int CanCompleteCircuit(int[] gas, int[] cost) {
        
        int n = gas.Length;
        int total = 0;
        int currentGas = 0;
        int start = 0;
        for(int i = 0; i < n; i++)
        {
            int diff = gas[i] - cost[i];
            total+= diff;
            currentGas += diff;
            if(currentGas < 0)
            {
                start = i + 1;
                currentGas = 0;
            }
        }

        return total >= 0 ? start : -1;
    }
}

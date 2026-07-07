public class Solution {
    public int CanCompleteCircuit(int[] gas, int[] cost) {
        int totalGas = 0;
        int currentGas = 0;
        int startStation = 0;

        for (int i = 0; i < gas.Length; i++) {
            int diff = gas[i] - cost[i];
            totalGas += diff;
            currentGas += diff;

            if (currentGas < 0) {
                startStation = i + 1;
                currentGas = 0;
            }
        }

        return (totalGas >= 0) ? startStation : -1;
    }
}
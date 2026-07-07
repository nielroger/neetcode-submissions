public class Solution {
    public int LeastInterval(char[] tasks, int n) {
        int[] counts = new int[26];
        foreach (char task in tasks) {
            counts[task - 'A']++;
        }

        Array.Sort(counts);
        int maxFreq = counts[25];
        int idleTime = (maxFreq - 1) * n;

        for (int i = 24; i >= 0 && counts[i] > 0; i--) {
            idleTime -= Math.Min(maxFreq - 1, counts[i]);
        }

        idleTime = Math.Max(0, idleTime);

        return tasks.Length + idleTime;
    }
}
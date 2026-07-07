public class Solution {
    public int LeastInterval(char[] tasks, int n) {
        

        int[] count = new int[26];
        for(int i = 0; i < tasks.Length; i++)
        {
            count[tasks[i] - 'A']++;
        }

        Array.Sort(count);
        int maxFreq = count[25];

        int idleTime = (maxFreq - 1) * n;

        for(int i = 24; i >= 0 && count[i] > 0; i--)
        {
            idleTime -= Math.Min(maxFreq - 1, count[i]);
        }

        idleTime = Math.Max(0, idleTime);

        return tasks.Length + idleTime;

    }
}

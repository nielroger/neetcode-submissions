public class Solution {
    public bool IsNStraightHand(int[] hand, int groupSize) {
        if (hand.Length % groupSize != 0) return false;

        var freq = new int[1001];
        for(int i = 0; i < hand.Length; i++)
        {
            freq[hand[i]]++;
        }

        for(int i = 0; i < freq.Length; i++)
        {
            while(freq[i] > 0)
            {
                for(int j = 0; j < groupSize; j++)
                {
                    if (i + j >= freq.Length || freq[i + j] == 0) return false;
                    freq[i + j]--;
                }
            }
        }
        return true;
    }
}
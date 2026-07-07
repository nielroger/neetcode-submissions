public class Solution {
    public bool CheckValidString(string s) {
        int low = 0;
        int high = 0;
        foreach (char c in s) {
            low += (c == '(') ? 1 : -1;
            high += (c != ')') ? 1 : -1;
            if (high < 0) return false;
            low = Math.Max(low, 0);
        }
        return low == 0;
    }
}
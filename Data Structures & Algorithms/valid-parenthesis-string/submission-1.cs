public class Solution {
    public bool CheckValidString(string s) {
        
        int low = 0;
        int high = 0;

        foreach(var letter in s)
        {
            low += letter == '(' ? 1 : -1;
            high += letter != ')' ? 1 : -1;
            if(high < 0) return false;
            low = Math.Max(low, 0);
        }

        return low == 0;
    }
}

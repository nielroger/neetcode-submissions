public class Solution {  
    public List<string> GenerateParenthesis(int n) {
        var result = new List<string>();
        BackTrack(result, "", 0, 0, n);
        return result;
    }

    public void BackTrack(List<string> result, string current, int open, int closed, int n)
    {
        if(current.Length == 2 * n)
        {
            result.Add(current);
            return;
        }

        if(open < n)
        {
            BackTrack(result, current + "(", open + 1, closed, n);
        }
        if(closed < open)
        {
            BackTrack(result, current + ")", open, closed + 1, n);
        }
    }
}
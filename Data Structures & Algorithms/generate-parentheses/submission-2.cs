public class Solution {  
    public List<string> GenerateParenthesis(int n) {

        var result = new List<string>();
        BackTrack(0, 0, "", result, n);
        return result;
    }

    public void BackTrack(int open, int closed, string current, List<string> result, int n)
    {
        if(current.Length == 2 * n) 
        {
            result.Add(current);
            return;
        }

        if(open < n)
        {
            BackTrack(open + 1, closed, current + "(", result, n);
        }
        if(closed < open)
        {
            BackTrack(open, closed + 1, current + ")", result, n);
        }
    }
}
public class Solution {  
    public List<string> GenerateParenthesis(int n) {

        var result = new List<string>();
        BackTrack(0, 0, n, result, "");
        return result;
    }

    public void BackTrack(int open, int closed, int n, List<string> result, string current)
    {
        if(current.Length == 2 * n) 
        {
            result.Add(current);
            return;
        }
            
        if(open < n)
        {
            BackTrack(open + 1, closed, n, result, current + "(");
        }
        
        if(closed < open)
        {
            BackTrack(open, closed + 1, n, result, current + ")");
        }
    }
}
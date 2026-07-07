public class Solution {
    private string[] phone = { "", "", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };

    public List<string> LetterCombinations(string digits) {
        var result =  new List<string>();
        if (string.IsNullOrEmpty(digits)) return result;
        BackTrack(digits, "", result, 0);
        return result;
    }

    public void BackTrack(string digits, string current, List<string> result, int index)
    {
        if(index == digits.Length)
        {
            result.Add(current);
            return;
        }

        foreach(var letter in phone[digits[index] - '0'])
        {
            BackTrack(digits, current + letter, result, index + 1);
        }
    }
}
public class Solution {
    public List<string> LetterCombinations(string digits) {
        if (string.IsNullOrEmpty(digits)) return new List<string>();
        var dict = new Dictionary<int, string>() { {2, "abc"}, {3, "def"}, {4, "ghi"}, {5, "jkl"}, {6, "mno"}, {7, "pqrs"}, {8, "tuv"}, {9, "wxyz"} };
        var result = new List<string>();
        BackTrack(digits, 0, result, dict, "");

        return result;

    }

    public void BackTrack(string digits, int index, List<string> result, Dictionary<int, string> dict, string current)
    {
        if(index == digits.Length) {
            result.Add(current);
            return;
        }

        int number = digits[index] - '0';
        foreach(var letter in dict[number])
        {
            BackTrack(digits, index + 1, result, dict, current + letter);
        }
    }
}
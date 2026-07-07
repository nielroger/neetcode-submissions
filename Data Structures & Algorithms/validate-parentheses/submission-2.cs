public class Solution {
    public bool IsValid(string s) {
        
        var stk = new Stack<char>();
        foreach(var letter in s)
        {System.Console.WriteLine(letter);
            if(letter == '(' || letter == '[' || letter == '{')
            {
                stk.Push(letter);
            }
            else
            {
                if(stk.Count == 0) return false;
                var topLetter = stk.Pop();
                if(letter  == ')' && topLetter != '(') return false;
                if(letter  == ']' && topLetter != '[') return false;
                if(letter  == '}' && topLetter != '{') return false;
            }
            
        }

        return stk.Count == 0;
    }
}
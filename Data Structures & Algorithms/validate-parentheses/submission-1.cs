public class Solution {
    public bool IsValid(string s) {
        
        var stk =  new Stack<char>();

        foreach(var letter in s)
        {
            if(letter  == '(' || letter  == '[' || letter  == '{')
            {
                stk.Push(letter);
            }
            else
            {
                if(stk.Count == 0) return false;
                var top = stk.Pop();
                if(top == '(' && letter != ')') return false;
                if(top == '[' && letter != ']') return false;
                if(top == '{' && letter != '}') return false;
            }
        }

        return stk.Count == 0;
    }
}

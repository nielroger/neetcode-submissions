public class Solution {
    public int EvalRPN(string[] tokens) {
        
        var stk = new Stack<int>();
        foreach(var token in tokens)
        {
            if(int.TryParse(token, out int val))
            {
                stk.Push(val);
            }
            else
            {
                var num2 = stk.Pop();
                var num1 = stk.Pop();
                if(token == "+")
                {
                    stk.Push(num1 + num2);
                }
                else if(token == "-")
                {
                    stk.Push(num1 - num2);
                }
                else if(token == "*")
                {
                    stk.Push(num1 * num2);                    
                }
                else
                {
                    stk.Push(num1 / num2);
                }
            }
        }

        return stk.Pop();
    }
}
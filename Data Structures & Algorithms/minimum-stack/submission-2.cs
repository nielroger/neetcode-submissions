public class MinStack {

    public Stack<int> stk;
    public Stack<int> minStk;
    public MinStack() {
        stk = new Stack<int>();
        minStk = new Stack<int>();
    }
    
    public void Push(int val) {
        stk.Push(val);

        if(minStk.Count == 0 || val <= minStk.Peek()) 
            minStk.Push(val);
    }
    
    public void Pop() {
        if(stk.Count > 0)
        {
            
            var temp = stk.Pop();
            if(temp == minStk.Peek()) minStk.Pop();
        }
    }
    
    public int Top() {
        if(stk.Count > 0)
        {
            return stk.Peek();
        }
        return -1;
    }
    
    public int GetMin() {
        if(minStk.Count > 0)
        {
            return minStk.Peek();
        }
        return -1;
    }
}

public class MinStack {

    Stack<int> minStack;
    Stack<int> stk;
    public MinStack() {
        minStack = new Stack<int>();
        stk = new Stack<int>();
    }
    
    public void Push(int val) {
        stk.Push(val);
        if(minStack.Count == 0 || val <= minStack.Peek())
        {
            minStack.Push(val);
        }
    }
    
    public void Pop() {
        
        if(stk.Count == 0) return;

        var top = stk.Pop();
        if(top == minStack.Peek()) minStack.Pop();
    }
    
    public int Top() {
        if(stk.Count == 0) return  -1;
        else
        {
            return stk.Peek();
        }
    }
    
    public int GetMin() {
        if(minStack.Count == 0) return -1;
        else
        {
            return minStack.Peek();
        }
    }
}

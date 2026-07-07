public class MinStack {

    Stack<int> stk;
    Stack<int> minStack;
    public MinStack() {
        stk =  new Stack<int>();
        minStack = new Stack<int>();
    }
    
    public void Push(int val) {
        stk.Push(val);
        if(minStack.Count == 0 || val <= minStack.Peek())
        {
            minStack.Push(val);
        }
    }
    
    public void Pop() {
        if(stk.Count > 0 && minStack.Count > 0)
        {
            var top = stk.Pop();
            if(top == minStack.Peek())
            {
                minStack.Pop();
            }
        }
    }
    
    public int Top() {
        if(stk.Count > 0)
        {
            return stk.Peek();
        }
        else
        {
            return -1;
        }
    }
    
    public int GetMin() {
        if(minStack.Count > 0){
            return minStack.Peek();    
        }
        else
        {
            return -1;
        }
    }
}
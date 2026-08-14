public class Solution {
    public List<string> FindItinerary(List<List<string>> tickets) {
        

        var graph = new Dictionary<string, PriorityQueue<string, string>>();

        foreach(var ticket in tickets)
        {
            var from = ticket[0];
            var to = ticket[1];

            if (!graph.ContainsKey(from))
            {
                graph[from] = new PriorityQueue<string, string>();
            }
            
            graph[from].Enqueue(to, to);
            
        }

        var stk = new Stack<string>();
        stk.Push("JFK");

        var itenary = new List<string>();

        while(stk.Count > 0)
        {
            var curr = stk.Peek();

            if(graph.ContainsKey(curr) && graph[curr].Count > 0)
            {
                stk.Push(graph[curr].Dequeue());
            }
            else
            {
                itenary.Add(stk.Pop());
            }
        }
        
        itenary.Reverse();
        return itenary;
        
    }
}

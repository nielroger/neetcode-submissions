public class Solution {
    public List<string> FindItinerary(List<List<string>> tickets) {
        

        var graph = new Dictionary<string, PriorityQueue<string, string>>();
        var stack = new Stack<string>();
        var itenary = new List<string>();

        foreach(var ticket in tickets)
        {            
            var src = ticket[0];
            var dst = ticket[1];

            if(!graph.ContainsKey(src))
            {                
                graph[src] = new PriorityQueue<string, string>();
            }

            graph[src].Enqueue(dst, dst);
        }

        stack.Push("JFK");

        while(stack.Count > 0)
        {            
            var curr = stack.Peek();

            if(graph.ContainsKey(curr) && graph[curr].Count > 0)
            {               
                 stack.Push(graph[curr].Dequeue());
            }
            else
            {                
                itenary.Add(stack.Pop());
            }
        }

        itenary.Reverse();
        return itenary;
    }
}
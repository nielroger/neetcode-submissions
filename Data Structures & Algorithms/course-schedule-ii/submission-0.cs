public class Solution
{
    // 0 = Unvisited, 1 = Visiting, 2 = Visited
    private int[] state;
    private List<int>[] adj;
    private List<int> result;

    public int[] FindOrder(int numCourses, int[][] prerequisites)
    {
        state  = new int[numCourses];
        adj    = new List<int>[numCourses];
        result = new List<int>();

        // Step 1: Build adjacency list
        for (int i = 0; i < numCourses; i++)
            adj[i] = new List<int>();

        foreach (var pre in prerequisites)
        {
            int a = pre[0];
            int b = pre[1];
            adj[b].Add(a);  // b must be taken before a → edge b → a
        }

        // Step 2: DFS every unvisited node
        for (int i = 0; i < numCourses; i++)
        {
            if (state[i] == 0)
            {
                if (HasCycle(i))
                    return new int[] {};  // Cycle found → impossible
            }
        }

        // Step 3: Reverse the result
        result.Reverse();
        return result.ToArray();
    }

    private bool HasCycle(int node)
    {
        // Currently in DFS path → cycle found
        if (state[node] == 1) return true;

        // Already fully explored → no cycle from here
        if (state[node] == 2) return false;

        // Mark as Visiting
        state[node] = 1;

        // DFS all neighbors
        foreach (int neighbor in adj[node])
        {
            if (HasCycle(neighbor))
                return true;
        }

        // Mark as Visited and add to result
        state[node] = 2;
        result.Add(node);   // ← only difference from CanFinish

        return false;
    }
}
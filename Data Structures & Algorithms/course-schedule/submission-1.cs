public class Solution {
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        
        List<int>[] adj = new List<int>[numCourses];

        for(int i =0 ; i < numCourses; i++)
        {
            adj[i] = new List<int>();            
        }

        foreach(var preq in prerequisites)
        {
            adj[preq[1]].Add(preq[0]);
        }

        int[] state = new int[numCourses];

        for(int i = 0; i < numCourses; i++)
        {
            if(state[i] == 0)
            {
                if(HasCycle(adj, state, i))
                {
                    return false;
                }
            }
        }

        return true;
    }

    public bool HasCycle(List<int>[] adj, int[] state, int i)
    {

        if(state[i] == 1) return true;

        if(state[i] == 2) return false;

        state[i] = 1;

        foreach(var edge in adj[i])
        {
            if(HasCycle(adj, state, edge))
                return true;
        }

        state[i] = 2;
        return false;
    }
}

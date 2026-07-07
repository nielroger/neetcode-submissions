public class Solution {
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        
        
        var adj =  new List<int>[numCourses];

        for(int i = 0; i < numCourses; i++)
        {
            adj[i] = new List<int>();
        }

        foreach(var edge in prerequisites)
        {
            adj[edge[1]].Add(edge[0]);
        }

        var state = new int[numCourses];

        for(int i = 0; i < numCourses; i++)
        {
            if(state[i] == 0)
            {
                if(HasCycle(adj, i, state))
                {
                    return false;
                }
            }
        }

        return true;
    }

    public bool HasCycle(List<int>[] adj, int course, int[] state)
    {
        if(state[course] == 1) return true;

        if(state[course] == 2) return false;

        state[course] = 1;

        foreach(var item in adj[course])
        {
            if(HasCycle(adj, item, state))
                return true;
        }

        state[course] = 2;
        return false;
    }
    
}

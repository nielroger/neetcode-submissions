public class Solution {

    
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        int[] state = new int[numCourses];
        var adj = new List<int>[numCourses];

        for(int i =0; i < numCourses;i++)
        {
            adj[i] = new List<int>();
        }

        foreach(var preq in prerequisites)
        {
            adj[preq[1]].Add(preq[0]);
        }

        for(int i =0; i < numCourses; i++)
        {
            if(state[i] == 0)
            {
                if(HasCycle(i, state, adj)) return false;
            }
        }

        return true;
    
    }

    public bool HasCycle(int course, int[] state, List<int>[] adj)
    {        
        if(state[course] == 1) return true;

        if(state[course] == 2) return false;

        state[course] = 1;

        foreach(var edge in adj[course])
        {
            if(HasCycle(edge, state, adj)) return true;
        }

        state[course] = 2;
        return false;
    }
}
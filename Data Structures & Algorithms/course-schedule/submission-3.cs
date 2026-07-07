public class Solution {
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        

        int[] visited = new int[numCourses];

        var adj =  new List<int>[numCourses];

        for(int i = 0; i < numCourses; i++)
        {
            adj[i] =  new List<int>();
        }

        for(int i = 0 ; i < prerequisites.Length; i++)
        {
            adj[prerequisites[i][1]].Add(prerequisites[i][0]);
        }

        for(int i = 0; i < numCourses; i++)
        { 
            if(visited[i] == 0)
            {
                if(HasCycle(adj, visited, i)) return false;
            }
        }

        return true;
    }

    public bool HasCycle(List<int>[] adj, int[] visited, int course)
    {
        if(visited[course] == 1) return true;

        if(visited[course] == 2) return false;

        visited[course] = 1;

        foreach(var item in adj[course])
        {
            if(HasCycle(adj, visited, item)) return true;
        }

        visited[course] = 2;
        return false;
    }
}

public class Solution {

    public int[] parent;
    public int[] rank;
    public int[] FindRedundantConnection(int[][] edges) {
        
        int n = edges.Length;
        parent = new int[n + 1];
        rank = new int[n + 1];

        for(int i = 0; i < parent.Length; i++)
        {
            parent[i] = i;
        }

        foreach(var edge in edges)
        {
            if(!Union(edge[0], edge[1]))
            {
                return new int[2]{edge[0], edge[1]};
            }
        }

        return new int[2]{0, 0};
    }

    public int Find(int x)
    {
        if (parent[x] != x)
        {
            parent[x] = Find(parent[x]);
        }

        return parent[x];
    }

    public bool Union(int x, int y)
    {
        int fx = Find(x); int fy = Find(y);

        if(fx == fy)
        {
            return false;
        }

        if(rank[fx] < rank[fy]) (fx, fy) = (fy, fx);

        parent[fy] = fx;
        if(rank[fx] == rank[fy]) rank[fx]++;
        return true;
    }
}
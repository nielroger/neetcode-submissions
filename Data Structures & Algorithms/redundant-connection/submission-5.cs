public class Solution {

    int[] parent;
    int[] rank;
    public int[] FindRedundantConnection(int[][] edges) {
        
        parent = new int[edges.Length + 1];
        rank = new int[edges.Length + 1];

        for(int i = 0; i < parent.Length; i++)
        {
            parent[i] = i;
        }

        for(int i = 0; i < edges.Length; i++)
        {
            if(!Union(edges[i][0], edges[i][1]))
                return new int[2]{ edges[i][0], edges[i][1]};
        }

        return new int[2]{ 0, 0};
    }

    public int Find(int i)
    {
        int x = parent[i];
        while(x != parent[x])
        {
            x = parent[parent[x]];
        }
        return x;
    }

    public bool Union(int x, int y)
    {
        int fx = Find(x); int fy = Find(y);
        if(fx == fy)
            return false;
        
        if(rank[fx] < rank[fy]) (fx, fy) = (fy, fx);
        parent[fy] = fx;
        if(rank[fx] == rank[fy]) rank[fx]++;
        return true;
    }
}

public class Solution {
    public int[] parent;
    public int[] rank;

    public int[] FindRedundantConnection(int[][] edges) {
        
        int n = edges.Length;
        parent = new int[n + 1];
        rank = new int[n + 1];

        for(int i = 0; i <=n; i++)
        {
            parent[i] = i;
        }

        foreach(var edge in edges)
        {
            if(!Union(edge[0], edge[1]))
                return edge;
        }

        return new int[0];
    }

    public int Find(int x)
    {
        while(x != parent[x])
        {
            parent[x] = parent[parent[x]];
            x = parent[x];
        }

        return x;
    }

    public bool Union(int x, int y)
    {
        int rx = Find(x);
        int ry = Find(y);

        if(rx == ry) return false;

        if(rank[rx] <  rank[ry]) (rx, ry) = (ry, rx);

        parent[ry] = rx;
        if(rank[rx] == rank[ry]) rank[rx]++;
        return true;
    }
}

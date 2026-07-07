public class Solution {
    public int LastStoneWeight(int[] stones) {
        
        var q = new PriorityQueue<int, int>(Comparer<int>.Create((a,b)=> b.CompareTo(a)));


        foreach(var stone in stones) 
        {
            q.Enqueue(stone, stone);
        }

        while(q.Count > 0)
        {
            var temp1 = q.Dequeue();
            if(q.Count == 0) return temp1;
            var temp2 = q.Dequeue();
            if(temp1 != temp2)
            {
                var diff = Math.Abs(temp1 - temp2);
                q.Enqueue(diff, diff);
            }            
        }

        return 0;
    }
}
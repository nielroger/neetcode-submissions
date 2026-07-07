public class Solution {
    public bool MergeTriplets(int[][] triplets, int[] target) {
        

        bool[] curr = new bool[3];

        foreach(var triplet in triplets)
        {
            if(triplet[0] <= target[0] && triplet[1] <= target[1] && triplet[2] <= target[2])
            {
                if(triplet[0] == target[0]) curr[0] = true;
                if(triplet[1] == target[1]) curr[1] = true;
                if(triplet[2] == target[2]) curr[2] = true;
            }
        }

        return curr[0] && curr[1] && curr[2];
    }
}

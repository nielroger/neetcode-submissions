public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        int n = position.Length;
        double[][] cars = new double[n][];
        for (int i = 0; i < n; i++) {
            cars[i] = new double[] { position[i], (double)(target - position[i]) / speed[i] };
        }
        
        Array.Sort(cars, (a, b) => b[0].CompareTo(a[0]));
        
        int fleets = 0;
        double currentTime = 0;
        foreach (var car in cars) {
            if (car[1] > currentTime) {
                fleets++;
                currentTime = car[1];
            }
        }
        return fleets;
    }
}
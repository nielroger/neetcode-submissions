public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        
        int n = position.Length;
        var cars = new double[n][];

        int fleet = 0;

        for(int i =0; i <n; i++)
        {
            cars[i] = new double[2]{ (double)position[i], (double)(target - position[i]) / speed[i]};
        }

        Array.Sort(cars, (a,b) => b[0].CompareTo(a[0]));
        double currentTime = 0.0;

        foreach(var car in cars)
        {
            if(car[1] > currentTime)
            {
                fleet++;
                currentTime = car[1];
            }
        }

        return fleet;
    }
}

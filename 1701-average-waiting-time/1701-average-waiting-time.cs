public class Solution {
    public double AverageWaitingTime(int[][] customers) {
        double totalWaitingTime = 0;
        int currentTime = 0;
        
        foreach (var customer in customers) {
            int arrivalTime = customer[0];
            int prepTime = customer[1];
            
            currentTime = Math.Max(currentTime, arrivalTime);
            int completionTime = currentTime + prepTime;
            totalWaitingTime += completionTime - arrivalTime;
            currentTime = completionTime;
        }
        
        return totalWaitingTime / customers.Length;
    }
}
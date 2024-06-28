public class Solution {
    public long MaximumImportance(int n, int[][] roads) {
           
        int[] connections = new int[n];
        foreach (var road in roads) {
            connections[road[0]]++;
            connections[road[1]]++;
        }
        

        int[] cities = Enumerable.Range(0, n).ToArray();
        Array.Sort(cities, (a, b) => connections[b].CompareTo(connections[a]));
        
        int[] values = new int[n];
        for (int i = 0; i < n; i++) {
            values[cities[i]] = n - i;
        }
        
        long totalImportance = 0;
        foreach (var road in roads) {
            totalImportance += values[road[0]] + values[road[1]];
        }
        
        return totalImportance;
    }
}
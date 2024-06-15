public class Solution {
    public int FindMaximizedCapital(int k, int w, int[] profits, int[] capital) {
               int n = profits.Length;
        var projects = new List<(int capital, int profit)>();

        for (int i = 0; i < n; i++) {
            projects.Add((capital[i], profits[i]));
        }

       
        projects.Sort((a, b) => a.capital.CompareTo(b.capital));

        
        var maxHeap = new SortedSet<(int profit, int index)>(Comparer<(int profit, int index)>.Create((a, b) => 
            a.profit != b.profit ? b.profit.CompareTo(a.profit) : b.index.CompareTo(a.index)));

        int projectIndex = 0;

        for (int i = 0; i < k; i++) {
           
            while (projectIndex < n && projects[projectIndex].capital <= w) {
                maxHeap.Add((projects[projectIndex].profit, projectIndex));
                projectIndex++;
            }

            
            if (maxHeap.Count == 0) break;

         
            var maxProfitProject = maxHeap.First();
            maxHeap.Remove(maxProfitProject);

           
            w += maxProfitProject.profit;
        }

        return w;
    }
}
public class Solution {
    public int MaxProfitAssignment(int[] difficulty, int[] profit, int[] worker) {
        
    var jobs = new List<(int difficulty, int profit)>();
    for (int i = 0; i < difficulty.Length; i++) {
        jobs.Add((difficulty[i], profit[i]));
    }

    jobs.Sort((a, b) => a.difficulty == b.difficulty ? b.profit.CompareTo(a.profit) :       a.difficulty.CompareTo(b.difficulty));

    Array.Sort(worker);

    int maxProfit = 0, bestProfit = 0, j = 0;
    foreach (var ability in worker) {
        while (j < jobs.Count && jobs[j].difficulty <= ability) {
            bestProfit = Math.Max(bestProfit, jobs[j].profit);
            j++;
        }
        maxProfit += bestProfit;
    }

    return maxProfit;
    }
}
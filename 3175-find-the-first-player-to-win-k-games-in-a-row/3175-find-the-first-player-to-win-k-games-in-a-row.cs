public class Solution {
    public int FindWinningPlayer(int[] skills, int k) {
        
        var queue = new Queue<int>(Enumerable.Range(0, skills.Length).ToList());
        int winStreak = 0;
        var currentWinner = queue.Dequeue();

        while(winStreak<k && winStreak < skills.Length - 1)
        {
            var next = queue.Dequeue();
            if (skills[currentWinner] > skills[next])
            {
                winStreak++;
                queue.Enqueue(next);
                
            }
            else
            {
                winStreak = 1;
                queue.Enqueue(currentWinner);
                currentWinner = next;
            }

        }

        return currentWinner;
    }
}
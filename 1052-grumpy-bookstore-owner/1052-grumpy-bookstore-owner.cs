public class Solution {
    public int MaxSatisfied(int[] customers, int[] grumpy, int minutes) {
         int n = customers.Length;
        int initialSatisfaction = 0;
        
        for (int i = 0; i < n; i++) {
            if (grumpy[i] == 0) {
                initialSatisfaction += customers[i];
            }
        }
        
        int additionalSatisfaction = 0;
        int currentWindowSatisfaction = 0;
        
        for (int i = 0; i < minutes; i++) {
            if (grumpy[i] == 1) {
                currentWindowSatisfaction += customers[i];
            }
        }
        
        additionalSatisfaction = currentWindowSatisfaction;
        
        for (int i = minutes; i < n; i++) {
            if (grumpy[i] == 1) {
                currentWindowSatisfaction += customers[i];
            }
            if (grumpy[i - minutes] == 1) {
                currentWindowSatisfaction -= customers[i - minutes];
            }
            additionalSatisfaction = Math.Max(additionalSatisfaction, currentWindowSatisfaction);
        }
        
        return initialSatisfaction + additionalSatisfaction;
    }
}
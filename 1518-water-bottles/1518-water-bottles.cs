public class Solution {
    public int NumWaterBottles(int numBottles, int numExchange) {
        int totalDrinks = 0;
        int fullBottles = numBottles;
        int emptyBottles = 0;
        
        while (fullBottles > 0) {
            
            totalDrinks += fullBottles;
            emptyBottles += fullBottles;
            
           
            fullBottles = emptyBottles / numExchange;
            emptyBottles = emptyBottles % numExchange;
        }
        
        return totalDrinks;
    }
}
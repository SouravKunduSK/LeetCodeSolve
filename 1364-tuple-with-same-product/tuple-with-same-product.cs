public class Solution {
    public int TupleSameProduct(int[] nums) {
        int length = nums.Length;
        int tupleCount = 0;
        
        Dictionary<int, int> productCount = new Dictionary<int, int>();
        for(int i = 0; i<length; ++i)
        {
            for(int j = i+1; j<length; ++j)
            {
                int product = nums[i]*nums[j];


                if(productCount.ContainsKey(product))
                {
                    tupleCount += productCount[product];
                }

                if(!productCount.ContainsKey(product))
                {
                    productCount[product] = 0;
                }

                productCount[product]++;
            }
        }

        return tupleCount*8;

    }
}
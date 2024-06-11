public class Solution {
    public int[] RelativeSortArray(int[] arr1, int[] arr2) {
        var orderDictionary = arr2.Select((value, index)=> new {value, index})
                                   .ToDictionary(pair=>pair.value, pair=> pair.index);

        var result = arr1.OrderBy(x=> orderDictionary
                         .ContainsKey(x) ? orderDictionary[x] : arr2.Length + x)
                         .ToArray();

        return result;
    }
}
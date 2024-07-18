/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public int CountPairs(TreeNode root, int distance) {
        int count = 0;

        
        List<int> DFS(TreeNode node) {
            if (node == null) return new List<int>();
            
            if (node.left == null && node.right == null) {
                return new List<int> { 1 }; 
            }
            
            var leftDistances = DFS(node.left);
            var rightDistances = DFS(node.right);
            
           
            foreach (int ld in leftDistances) {
                foreach (int rd in rightDistances) {
                    if (ld + rd <= distance) {
                        count++;
                    }
                }
            }
            
       
            var currentDistances = new List<int>();
            foreach (int ld in leftDistances) {
                currentDistances.Add(ld + 1);
            }
            foreach (int rd in rightDistances) {
                currentDistances.Add(rd + 1);
            }
            
            return currentDistances;
        }

        DFS(root);
        return count;
    }
}
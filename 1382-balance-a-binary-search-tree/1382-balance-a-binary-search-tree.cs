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
    public TreeNode BalanceBST(TreeNode root) {
        List<int> sortedValues = new List<int>();
        InOrderTraversal(root, sortedValues);
        return BuildBalancedBST(sortedValues, 0, sortedValues.Count - 1);
    }
    
    private void InOrderTraversal(TreeNode node, List<int> sortedValues) {
        if (node == null) return;
        InOrderTraversal(node.left, sortedValues);
        sortedValues.Add(node.val);
        InOrderTraversal(node.right, sortedValues);
    }
    
    private TreeNode BuildBalancedBST(List<int> sortedValues, int left, int right) {
        if (left > right) return null;
        
        int mid = left + (right - left) / 2;
        TreeNode root = new TreeNode(sortedValues[mid]);
        root.left = BuildBalancedBST(sortedValues, left, mid - 1);
        root.right = BuildBalancedBST(sortedValues, mid + 1, right);
        
        return root;
    }
}
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
    public TreeNode CreateBinaryTree(int[][] descriptions) {
        Dictionary<int, TreeNode> nodeMap = new Dictionary<int, TreeNode>();
        HashSet<int> children = new HashSet<int>();

        foreach (var description in descriptions) {
            int parentVal = description[0];
            int childVal = description[1];
            bool isLeft = description[2] == 1;

            if (!nodeMap.ContainsKey(parentVal)) {
                nodeMap[parentVal] = new TreeNode(parentVal);
            }
            if (!nodeMap.ContainsKey(childVal)) {
                nodeMap[childVal] = new TreeNode(childVal);
            }

            if (isLeft) {
                nodeMap[parentVal].left = nodeMap[childVal];
            } else {
                nodeMap[parentVal].right = nodeMap[childVal];
            }

            children.Add(childVal);
        }

        foreach (var key in nodeMap.Keys) {
            if (!children.Contains(key)) {
                return nodeMap[key];
            }
        }

        return null;
    }
}
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
    public string GetDirections(TreeNode root, int startValue, int destValue) {
        List<char> pathToStart = new List<char>();
        List<char> pathToDest = new List<char>();

        
        FindPath(root, startValue, pathToStart);
        FindPath(root, destValue, pathToDest);

       
        int i = 0;
        while (i < pathToStart.Count && i < pathToDest.Count && pathToStart[i] == pathToDest[i]) {
            i++;
        }

      
        string upMoves = new string('U', pathToStart.Count - i);

        
        string downMoves = new string(pathToDest.Skip(i).ToArray());

        return upMoves + downMoves;
    }

    private bool FindPath(TreeNode root, int value, List<char> path) {
        if (root == null) {
            return false;
        }
        if (root.val == value) {
            return true;
        }

        path.Add('L');
        if (FindPath(root.left, value, path)) {
            return true;
        }
        path.RemoveAt(path.Count - 1);

        path.Add('R');
        if (FindPath(root.right, value, path)) {
            return true;
        }
        path.RemoveAt(path.Count - 1);

        return false;
    }
}
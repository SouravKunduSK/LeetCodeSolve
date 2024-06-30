public class Solution {
    public int MaxNumEdgesToRemove(int n, int[][] edges) {
        int[] parentA = new int[n + 1];
        int[] parentB = new int[n + 1];
        
        for (int i = 1; i <= n; i++) {
            parentA[i] = i;
            parentB[i] = i;
        }
        
        int find(int[] parent, int x) {
            if (parent[x] != x) parent[x] = find(parent, parent[x]);
            return parent[x];
        }
        
        bool union(int[] parent, int x, int y) {
            int rootX = find(parent, x);
            int rootY = find(parent, y);
            if (rootX == rootY) return false;
            parent[rootX] = rootY;
            return true;
        }
        
        int edgesUsed = 0;
        
        
        foreach (var edge in edges) {
            if (edge[0] == 3) {
                if (union(parentA, edge[1], edge[2]) | union(parentB, edge[1], edge[2])) {
                    edgesUsed++;
                }
            }
        }
        
   
        foreach (var edge in edges) {
            if (edge[0] == 1) {
                if (union(parentA, edge[1], edge[2])) {
                    edgesUsed++;
                }
            } else if (edge[0] == 2) {
                if (union(parentB, edge[1], edge[2])) {
                    edgesUsed++;
                }
            }
        }
        
       
        bool canTraverse(int[] parent) {
            int root = find(parent, 1);
            for (int i = 2; i <= n; i++) {
                if (find(parent, i) != root) return false;
            }
            return true;
        }
        
        if (canTraverse(parentA) && canTraverse(parentB)) {
            return edges.Length - edgesUsed;
        }
        
        return -1;
    }
}
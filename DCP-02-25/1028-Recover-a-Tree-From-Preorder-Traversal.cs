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
    private List<Tuple<int,int>> GenerateNodesWithDepth(string traversal)
    {
        List<Tuple<int,int>> nodes = new(); // node, depth
        int idx = 0;
        while(idx < traversal.Length) {
            int depth =0, node = 0;
            while(idx < traversal.Length && traversal[idx] == '-')
            {
                depth++; idx++;
            }
            while(idx < traversal.Length && traversal[idx] >= '0' && traversal[idx] <='9')
            {
                node = node*10 + (int)(traversal[idx]-'0');
                idx++;
            }
            nodes.Add(new Tuple<int,int>(node, depth));
        }
        return nodes;
    }

    List<Tuple<int,int>> nodes; // node, depth

    public TreeNode RecoverFromPreorder(string traversal) {
        nodes = new();
        nodes = GenerateNodesWithDepth(traversal);
        TreeNode root = new TreeNode(nodes[0].Item1);
        DFS(root,  0);
        return root;
    }
    int idx = 1;
    private void DFS(TreeNode tree, int curDepth)
    {
        if(idx == nodes.Count) return;

        if(idx < nodes.Count && curDepth+1 == nodes[idx].Item2 && tree.left == null){
                tree.left = new TreeNode(nodes[idx].Item1);
                idx++;
                DFS(tree.left, curDepth+1);
        }
        if(idx < nodes.Count && curDepth+1 == nodes[idx].Item2 && tree.right == null){
                tree.right = new TreeNode(nodes[idx].Item1);
                idx++;
                DFS(tree.right, curDepth+1);
        }
    }
}  
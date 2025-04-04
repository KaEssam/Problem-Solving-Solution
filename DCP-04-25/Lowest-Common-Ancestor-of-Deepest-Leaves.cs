public class Solution
{
    public TreeNode LcaDeepestLeaves(TreeNode root)
    {
        return Dfs(root).node;
    }

    private record Result(TreeNode node, int h);

    private Result Dfs(TreeNode node)
    {
        if (node == null)
        {
            return new (null, 0);
        }

        return (Dfs(node.left), Dfs(node.right)) switch
        {
            (var l, var r) when l.h == r.h => new (node, l.h + 1),
            (var l, var r) when l.h >  r.h => new (l.node, l.h + 1),
            (var l, var r) when l.h <  r.h => new (r.node, r.h + 1),
        };
    }
}
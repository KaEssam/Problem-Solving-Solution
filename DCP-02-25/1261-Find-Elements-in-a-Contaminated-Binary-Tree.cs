public class FindElements {
    private readonly TreeNode _root;

    public FindElements(TreeNode root)
    {
        _root = root;
    }

    public bool Find(int target)
    {
        if (target == 0)
        {
            return _root != null;
        }
        
        var path = target + 1;
        var depth = int.Log2(path);
        var node = _root;
        var mask = 1 << (depth - 1);
        while (mask > 0 && node != null)
        {
            node = (path & mask) == 0 ? node.left : node.right;
            mask >>= 1;
        }

        return node != null;
    }
}
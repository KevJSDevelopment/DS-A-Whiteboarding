public class BinaryTree
{
    public int GetMinDepth(TreeNode root)
    {
        if(root == null) return 0;

        Queue<TreeNode> nodeQ = new();
        nodeQ.Enqueue(root);
        int depth = 1;

        while(nodeQ.Count > 0)
        {
            int levelSize = nodeQ.Count;
            while(levelSize-- > 0)
            {
                TreeNode curr = nodeQ.Dequeue();
                if(curr.left == null && curr.right == null) return depth;
                if(curr.left != null) nodeQ.Enqueue(curr.left);
                if(curr.right != null) nodeQ.Enqueue(curr.right);
            }
            depth++;
        }

        return depth;
    }
}
//implement poost order traversal (recursion)
/*  post order:
        if(root == null) return;

        Invert(root.left)
        Invert(root.right)

        swap left and right
        
        return root
*/

public class InvertBinaryTree {
    public TreeNode InvertTree(TreeNode root) {
        if(root == null) return new TreeNode();

        InvertTree(root.left);
        InvertTree(root.right);

        TreeNode temp = root.left;
        root.left = root.right;
        root.right = temp;

        return root;
    }
}

public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

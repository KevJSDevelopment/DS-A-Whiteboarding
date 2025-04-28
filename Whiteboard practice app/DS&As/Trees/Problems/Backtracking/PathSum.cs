public class PathSum {
    public bool HasPathSum(TreeNode root, int targetSum) {
        return ValidPath(root, targetSum, 0);
    }

    public bool ValidPath(TreeNode root, int targetSum, int currentSum)
    {
        if(root == null) return false;
        currentSum = currentSum + root.val;

        if(root.left == null && root.right == null && currentSum == targetSum) return true;
        if(ValidPath(root.right, targetSum, currentSum)) return true;
        if(ValidPath(root.left, targetSum, currentSum)) return true;
        currentSum -= root.val;
        return false;
    }
}
public class BTLevelOrderTraversal
{
    public List<List<int>> LevelOrder(TreeNode root) {
        List<List<int>> returnList = new();
        if(root == null) return returnList;

        Queue<TreeNode> nodeQ = new();
        nodeQ.Enqueue(root);
        while(nodeQ.Count > 0)
        {
            List<int> levelList = new();
            int count = nodeQ.Count;
            for(int i = 0; i < count; i++)
            {
                var current = nodeQ.Dequeue();
                levelList.Add(current.val);
                if(current.left != null) nodeQ.Enqueue(current.left);
                if(current.right != null) nodeQ.Enqueue(current.right);
            }
            returnList.Add(levelList);
        }
        return returnList;
    }
}
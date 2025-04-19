public class BTRightSideView {
    public List<int> RightSideView(TreeNode root) {
        List<int> returnList = new();
        if(root == null) return returnList;

        Queue<TreeNode> nodeQ = new();
        nodeQ.Enqueue(root);

        while(nodeQ.Count > 0)
        {
            int levelCount = nodeQ.Count;
            for(int i = 0; i < levelCount; i++)
            {
                var curr = nodeQ.Dequeue();
                if(i == levelCount - 1) returnList.Add(curr.val);
                if(curr.left != null) nodeQ.Enqueue(curr.left);
                if(curr.right != null) nodeQ.Enqueue(curr.right);
            }
        }

        return returnList;
    }
}
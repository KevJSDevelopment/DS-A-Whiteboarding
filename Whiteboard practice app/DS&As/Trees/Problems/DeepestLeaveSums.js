var deepestLeavesSum = (root) => 
{
    if(!root) return 0;

    let nodeQ = [root];

    let levelSum = 0;
    while(nodeQ.length > 0)
    {
        let levelLength = nodeQ.length;
        levelSum = 0;
        while(levelLength-- > 0)
        {
            let curr = nodeQ.shift();
            if(curr.left) nodeQ.push(curr.left);
            if(curr.right) nodeQ.push(curr.right);
            levelSum += curr.val;
        }
    }

    return levelSum;
}

/*
Given the root of a binary tree, return the sum of values of its deepest leaves.
 

Example 1:


Input: root = [1,2,3,4,5,null,6,7,null,null,null,null,8]
Output: 15
Example 2:

Input: root = [6,7,8,2,7,1,3,9,null,1,4,null,null,null,5]
Output: 19
 

Answer:

utilize BFS to track the sum of each level, reset at the start of each level

return the sum
*/
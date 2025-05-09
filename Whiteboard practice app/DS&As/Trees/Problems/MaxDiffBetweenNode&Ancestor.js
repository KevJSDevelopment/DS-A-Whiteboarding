/*
Given the root of a binary tree, find the maximum value v for which there exist different nodes a and b where v = |a.val - b.val| and a is an ancestor of b.

A node a is an ancestor of b if either: any child of a is equal to b or any child of a is an ancestor of b.


Answer:

    use postorder traversal to travers the tree
    track highest and lowest numbers in each traversal

    return the absolut max difference between root and its descendants
*/

var maxAncestorDiff = function(root) {
    if(!root) return 0;
    
    return getMinMaxValues(root, root.val, root.val); 
};

var getMinMaxValues = (node, currMin, currMax) => 
{
    if (!node) {
        // Base case: return the max difference (0 for null node)
        return currMax - currMin;
    }

    // Update min and max with current node's value
    currMin = Math.min(currMin, node.val);
    currMax = Math.max(currMax, node.val);
    
    
    // Recurse on left and right subtrees
    const leftDiff = getMinMaxValues(node.left, currMin, currMax);
    const rightDiff = getMinMaxValues(node.right, currMin, currMax);

    return Math.max(leftDiff, rightDiff);
};

console.log(getMinMaxValues())
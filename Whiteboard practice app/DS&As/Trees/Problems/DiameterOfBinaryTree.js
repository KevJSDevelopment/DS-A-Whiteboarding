var diameterOfBinaryTree = function(root) {
    let diameter = 0; // Global variable to track max diameter
    
    function longestPath(node) {
        if (!node) return -1; // Base case: null node has height -1
        
        // Compute heights of left and right subtrees
        let leftHeight = longestPath(node.left);
        let rightHeight = longestPath(node.right);
        
        // Update global diameter: path through current node
        diameter = Math.max(diameter, leftHeight + rightHeight + 2);
        
        // Return height of current subtree
        return Math.max(leftHeight, rightHeight) + 1;
    }
    
    longestPath(root); // Compute diameter
    return diameter;
};
var minDepth = function(root) {
    if(!root) return 0;
    
    let queue = [root];
    let depth = 1;
    let curr;
    while(queue.length > 0)
    {
        let levelSize = queue.length;
        while(levelSize > 0){
            curr = queue.shift();
            if(!curr.left && !curr.right) return depth;
            if(curr.left) queue.push(curr.left);
            if(curr.right) queue.push(curr.right);
            levelSize--;
        }
        depth++;
    }
    
    return depth;
};

/* 
implement bfs, return the level where the first leaf node appears

    to implement bfs, we need to have a queue
    while iterate over the queue
    set current level length = queue size
    while level length > 0, we iterate over the level
    we will check if curr has a left or rigth node
    if not, then return depth
    if one or both do, we push the left &/or right node 
    subtract 1 from level length for each iteration
*/
var zigzagLevelOrder = function(root) {
    if(!root) return [];
    
    let nodeQ = [root];
    let depth = 0;

    let endArr = [];
    while(nodeQ.length > 0)
    {
        let levelLength = nodeQ.length;
        let returnarr = [];
        while(levelLength-- > 0)
        {
            let curr = nodeQ.shift();

            if(curr.left) nodeQ.push(curr.left);
            if(curr.right) nodeQ.push(curr.right);

            if(depth % 2 == 0)
            {
                returnarr.push(curr.val);
            }
            else 
            {
                returnarr.unshift(curr.val);
            }
        }
        endArr.push(returnarr);
        depth++;
    }

    return endArr;
};
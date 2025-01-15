/*
Example 1: Given an integer array nums, an array queries where queries[i] = [x, y] and an integer limit, 
return a boolean array that represents the answer to each query. 
A query is true if the sum of the subarray from x to y is less than limit, or false otherwise.

For example, given nums = [1, 6, 3, 2, 7, 2], queries = [[0, 3], [2, 5], [2, 4]], and limit = 13, 
the answer is [true, false, true]. 

For each query, the subarray sums are [12, 14, 12].
*/

var answerQueries = function(nums, queries, limit) {
    let prefix = [nums[0]];
    for (let i = 1; i < nums.length; i++) {
        prefix.push(nums[i] + prefix[prefix.length - 1]);
    }
    
    let ans = [];
    for (const [x, y] of queries) {
        let curr = prefix[y] - prefix[x] + nums[x];
        ans.push(curr < limit);
    }
    
    return ans;
};

/*
Example 2: 2270. Number of Ways to Split Array

Given an integer array nums, find the number of ways to split the array into two parts 
so that the first section has a sum greater than or equal to the sum of the second section. 
The second section should have at least one number.
*/

var waysToSplitArray = function(nums) {
    let n = nums.length;
    
    let prefix = [nums[0]];
    for (let i = 1; i < n; i++) {
        prefix.push(nums[i] + prefix[prefix.length - 1]);
    }
    
    let ans = 0;
    for (let i = 0; i < n - 1; i++) {
        let leftSection = prefix[i];
        let rightSection = prefix[n - 1] - prefix[i];
        if (leftSection >= rightSection) {
            ans++;
        }
    }
    
    return ans;
};
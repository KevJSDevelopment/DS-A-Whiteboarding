var minimumOperations = function(nums) {
    const uniqueValues = {};

    nums.forEach(num => {
        if(!uniqueValues[num] && num != 0) uniqueValues[num] = true;
    });

    return Object.keys(uniqueValues).length;
};

/*
    iterate over nums storing each unique value in a dictionary, then return the count of keys
*/

console.log(minimumOperations([1,5,0,3,5]));
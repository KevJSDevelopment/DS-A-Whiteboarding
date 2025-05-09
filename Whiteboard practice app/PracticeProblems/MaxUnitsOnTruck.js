/*
You are assigned to put some amount of boxes onto one truck. You are given a 2D array boxTypes, where boxTypes[i] = [numberOfBoxesi, numberOfUnitsPerBoxi]:

numberOfBoxesi is the number of boxes of type i.
numberOfUnitsPerBoxi is the number of units in each box of the type i.
You are also given an integer truckSize, which is the maximum number of boxes that can be put on the truck. You can choose any boxes to put on the truck as long as the number of boxes does not exceed truckSize.

Return the maximum total number of units that can be put on the truck.

 

Example 1:

Input: boxTypes = [[1,3],[2,2],[3,1]], truckSize = 4
Output: 8
Explanation: There are:
- 1 box of the first type that contains 3 units.
- 2 boxes of the second type that contain 2 units each.
- 3 boxes of the third type that contain 1 unit each.
You can take all the boxes of the first and second types, and one box of the third type.
The total number of units will be = (1 * 3) + (2 * 2) + (1 * 1) = 8.
Example 2:

Input: boxTypes = [[5,10],[2,5],[4,7],[3,9]], truckSize = 10
Output: 91

solving: 

sort the boxtypes by units per box in desc order.
iterate through the boxes, subtracting count of boxes and adding to totalunits
once truck is full, return total units
 */

var maximumUnits = function(boxTypes, truckSize) {
    let boxSorted = boxTypes.sort((num1, num2) => {
        return  num2[1] - num1[1] 
    });

    let i = 0;
    let totalUnits = 0;
    while(truckSize > 0 && i <= boxSorted.length - 1)
    {
        console.log(boxSorted, i, boxSorted.length - 1)
        if(boxSorted[i][0] > 0){
            totalUnits += boxSorted[i][1];
            truckSize--;
            boxSorted[i][0]--;
        } else i++;
    }

    return totalUnits;
};

console.log(maximumUnits([[1,3],[5,5],[2,5],[4,2],[4,1],[3,1],[2,2],[1,3],[2,5],[3,2]], 35));
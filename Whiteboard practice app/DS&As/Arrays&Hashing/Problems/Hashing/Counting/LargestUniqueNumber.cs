/* 
    Given an integer array nums, return the largest integer that only occurs once. If no integer occurs once, return -1.

    Example 1:

    Input: nums = [5,7,3,9,4,9,8,3,1]
    Output: 8
    Explanation: The maximum integer in the array is 9 but it is repeated. The number 8 occurs only once, so it is the answer.
    Example 2:

    Input: nums = [9,9,8,8]
    Output: -1
    Explanation: There is no number that occurs only once.
*/
public class LargestUniqueNumber
{
    public int GetLargestUnique(int[] nums)
    {
        Dictionary<int, int> numberCounts = new();

        for(int i = 0; i < nums.Length; i++)
        {
            if(numberCounts.Keys.Contains(nums[i])) numberCounts[nums[i]] += 1;
            else numberCounts[nums[i]] = 1;
        }

        int largestUnique = -1;
        foreach(int key in numberCounts.Keys)
        {
            if(key > largestUnique && numberCounts[key] == 1) largestUnique = key;
        }

        return largestUnique;
    }
}
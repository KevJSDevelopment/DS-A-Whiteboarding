/*
Given a binary array nums and an integer k, return the maximum number of consecutive 1's in the array if you can flip at most k 0's.

Example 1:

Input: nums = [1,1,1,0,0,0,1,1,1,1,0], k = 2
Output: 6
Explanation: [1,1,1,0,0,{1,1,1,1,1,1}]
Bolded numbers were flipped from 0 to 1. The longest subarray is underlined.
Example 2:

Input: nums = [0,0,1,1,0,0,1,1,1,0,1,1,0,0,0,1,1,1,1], k = 3
Output: 10
Explanation: [0,0,{1,1,1,1,1,1,1,1,1,1},0,0,0,1,1,1,1]
Bolded numbers were flipped from 0 to 1. The longest subarray is underlined.
 */

/*
left, right, flippedCount, maxLength = 0

while left < nums.length
    if maxLength < right - left
        maxLength = right - left
        
    if nums[right] + 1 == 1 or flippedCount < k
        right++
    else
        left++
        right = left
        
return maxLength
*/
public class MaxConsecutiveOnesIII {
    
    public int LongestOnes(int[] nums, int k) {
        if(k >= nums.Length) return k;

        int l = 0;
        int r = l;
        int startPoint = nums[l] == 0 ? -1 : 0;
        while(r < nums.Count() && startPoint < 0)
        {
            if(nums[r] == 1) startPoint = r + 1 < k ? k - (k - r + 1) : r - k;
            Console.WriteLine($"{l}, {r}, {startPoint}");
            r++;
        }

        if(startPoint == -1) return 0;

        l = startPoint;
        r = l;
        int count = nums[l] == 0 ? 1 : 0;
        int maxLength = 0;

        while (l < nums.Count() && r < nums.Count())
        {  
            if(r - l + 1 > maxLength) maxLength = r - l + 1;
            Console.WriteLine($"{l}, {r}, {maxLength}");
            if(r + 1 < nums.Count() && nums[r+1] == 1) r++;
            else if(count < k)
            {
                count++;
                r++;
            }
            else{
                if(nums[l] == 0) count--;
                l++;
            }
        }

        return maxLength;
    }
}
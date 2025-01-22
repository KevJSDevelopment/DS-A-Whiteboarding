/*
You are given a 0-indexed array nums of n integers, and an integer k.

The k-radius average for a subarray of nums centered at some index i 
with the radius k is the average of all elements in nums between the indices i - k and i + k (inclusive). 

If there are less than k elements before or after the index i, then the k-radius average is -1.
Build and return an array avgs of length n where avgs[i] is the k-radius average for the subarray centered at index i.

The average of x elements is the sum of the x elements divided by x, using integer division. 
The integer division truncates toward zero, which means losing its fractional part.

For example, the average of four elements 2, 3, 1, and 5 is (2 + 3 + 1 + 5) / 4 = 11 / 4 = 2.75, which truncates to 2.

Example 1:
Input: nums = [7,4,3,9,1,8,5,2,6], k = 3
Output: [-1,-1,-1,5,4,4,-1,-1,-1]
Explanation:
- avg[0], avg[1], and avg[2] are -1 because there are less than k elements before each index.
- The sum of the subarray centered at index 3 with radius 3 is: 7 + 4 + 3 + 9 + 1 + 8 + 5 = 37.
  Using integer division, avg[3] = 37 / 7 = 5.
- For the subarray centered at index 4, avg[4] = (4 + 3 + 9 + 1 + 8 + 5 + 2) / 7 = 4.
- For the subarray centered at index 5, avg[5] = (3 + 9 + 1 + 8 + 5 + 2 + 6) / 7 = 4.
- avg[6], avg[7], and avg[8] are -1 because there are less than k elements after each index.
Example 2:

Input: nums = [100000], k = 0
Output: [100000]
Explanation:
- The sum of the subarray centered at index 0 with radius 0 is: 100000.
  avg[0] = 100000 / 1 = 100000.
Example 3:

Input: nums = [8], k = 100000
Output: [-1]
Explanation: 
- avg[0] is -1 because there are less than k elements before and after index 0.

*/

public class KRadiusAverages
{
    public int[] GetAverages(int[] nums, int k)
    {
        int[] averages = new int[nums.Length];
        Array.Fill(averages, -1);

        int[] prefixSum = new int[nums.Length];
        prefixSum[0] = nums[0];

        for(int n = 1; n < nums.Length; n++)
        {
            prefixSum[n] = prefixSum[n - 1] + nums[n];
        }

        int i = k;
        while(i < nums.Length - k)
        {
            int left = 0;
            if(i > k) left = prefixSum[i - (k + 1)];
            int sum = prefixSum[i+k] - left;
            int avg =  sum / ((k*2)+1);
            averages[i] = avg;
            Console.WriteLine(avg);
            i++;
        }

        return averages;
    }
}

/* Above solution failed 1 test case, had to update to make ints long ints. See below solution to resolve this:

Here's the fixed solution using long instead of int:

public class Solution {
    public int[] GetAverages(int[] nums, int k) {
        int[] averages = new int[nums.Length];
        Array.Fill(averages, -1);
        
        // Use long array for prefix sums to avoid overflow
        long[] prefixSum = new long[nums.Length];
        prefixSum[0] = nums[0];
        for(int n = 1; n < nums.Length; n++)
        {
            prefixSum[n] = prefixSum[n - 1] + nums[n];
        }
        
        int i = k;
        while(i < nums.Length - k)
        {
            long left = 0;
            if(i > k) left = prefixSum[i - (k + 1)];
            long sum = prefixSum[i+k] - left;
            // Cast the divisor to long to ensure long division
            int avg = (int)(sum / ((long)(k*2)+1));
            averages[i] = avg;
            i++;
        }
        return averages;
    }
}

The key changes are:

Changed prefixSum array to be of type long[] instead of int[]
Changed sum and left variables to be long instead of int
Cast the divisor (k*2)+1 to long to ensure the division is done with long arithmetic
Cast the final result back to int for the averages array

This should now handle the large test case correctly without integer overflow.
*/
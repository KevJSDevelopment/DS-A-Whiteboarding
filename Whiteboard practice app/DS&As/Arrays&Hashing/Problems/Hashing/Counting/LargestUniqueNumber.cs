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
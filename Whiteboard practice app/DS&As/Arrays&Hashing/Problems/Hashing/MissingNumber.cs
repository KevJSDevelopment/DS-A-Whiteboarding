public class MissingNumber
{
    public int CheckMissingNumber(int[] nums)
    {
        HashSet<int> ints = new HashSet<int>();
        int i = 0;
        while(i < nums.Length)
        {
            ints.Add(nums[i]);
            i++;
        }

        i = 0;

        while(i <= nums.Length)
        {
            if(!ints.Contains(i)) return i;
            i++;
        }

        return -1;
    }
}
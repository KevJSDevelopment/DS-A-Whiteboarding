/*
You're given strings jewels representing the types of stones that are jewels, and stones representing the stones you have. 
Each character in stones is a type of stone you have. You want to know how many of the stones you have are also jewels.

Letters are case sensitive, so "a" is considered a different type of stone from "A".

Example 1:

Input: jewels = "aA", stones = "aAAbbbb"
Output: 3
Example 2:

Input: jewels = "z", stones = "ZZ"
Output: 0

*/

public class JewelsAndStones
{
    public int GetNumberOfJewels(string jewels, string stones)
    {
        Dictionary<char, int> jewelHash = new();

        for(int i = 0; i < jewels.Length;i++)
        {
            if(!jewelHash.Keys.Contains(jewels[i])) jewelHash[jewels[i]] = 0;
        }

        int count = 0;

        for(int j = 0; j < stones.Length; j++)
        {
            if(jewelHash.Keys.Contains(stones[j])) count++;
        }

        return count;
    }
}
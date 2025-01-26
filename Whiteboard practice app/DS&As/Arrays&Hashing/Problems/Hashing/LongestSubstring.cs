/*
Given a string s, find the length of the longest substring without repeating characters.

 

Example 1:

Input: s = "abcabcbb"
Output: 3
Explanation: The answer is "abc", with the length of 3.
Example 2:

Input: s = "bbbbb"
Output: 1
Explanation: The answer is "b", with the length of 1.
Example 3:

Input: s = "pwwkew"
Output: 3
Explanation: The answer is "wke", with the length of 3.
Notice that the answer must be a substring, "pwke" is a subsequence and not a substring.
*/

public class LongestSubstring
{
    public int GetLongestSubstringWithoutRepeatingCharacters(string s)
    {
        Dictionary<char, bool> seen = new();
        int maxLength = 0;
        int i = 0;
        int j = i;
        
        while(i < s.Length) {
            if(!seen.ContainsKey(s[j])) {
                seen[s[j]] = true;
                maxLength = Math.Max(maxLength, j - i + 1);
                
                if(j == s.Length - 1) {
                    i++;
                    j = i;
                    seen.Clear();
                }
                else j++;
            }
            else {
                seen.Clear();
                i++;
                j = i;
            }
        }
        return maxLength;
    }
}
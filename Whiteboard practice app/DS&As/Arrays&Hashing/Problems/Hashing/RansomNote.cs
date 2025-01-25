/*
Given two strings ransomNote and magazine, return true if ransomNote can be constructed by using the letters from magazine and false otherwise.

Each letter in magazine can only be used once in ransomNote.

Input: ransomNote = "a", magazine = "b"
Output: false
Example 2:

Input: ransomNote = "aa", magazine = "ab"
Output: false
Example 3:

Input: ransomNote = "aa", magazine = "aab"
Output: true
*/

public class RansomNote
{
    public bool IsRansomNote(string ransomNote, string magazine)
    {
        Dictionary<char, int> magazineCharCount = new();
        for(int i = 0; i < magazine.Length; i++)
        {
            if(magazineCharCount.Keys.Contains(magazine[i])) magazineCharCount[magazine[i]] += 1;
            else magazineCharCount[magazine[i]] = 1;
        }

        for(int j = 0; j < ransomNote.Length; j++)
        {
            if(magazineCharCount.Keys.Contains(ransomNote[j]) && magazineCharCount[ransomNote[j]] > 0)
            {
                magazineCharCount[ransomNote[j]] -= 1;
            } else return false;
        }

        return true;
    }
}
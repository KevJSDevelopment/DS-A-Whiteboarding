/* Solution options:
Brute force:
    loop over all strings, compare each character to characters for strings in existing lists
    if string matches (same number of the same characters), group in same list
    otherwise keep checking
    if all lists are checked and no matches, create a new list

    repeat until all words are assigned a list

    return list of lists

*/

public class GroupAnagrams 
{
    public List<List<string>> Group(string[] strs) 
    {
        // Use Dictionary to group anagrams using sorted string as key
        var groups = new Dictionary<string, List<string>>();
        
        foreach (string str in strs)
        {
            // Sort characters to create a key
            char[] chars = str.ToCharArray();
            Array.Sort(chars);
            string key = new string(chars);
            
            // Add to existing group or create new group
            if (!groups.ContainsKey(key))
            {
                groups[key] = new List<string>();
            }
            groups[key].Add(str);
        }
        
        // Convert dictionary values to list
        return groups.Values.Cast<List<string>>().ToList();
    }
}
public class IsPangram
{
    public bool CheckIsPangram(string s)
    {
        Dictionary<char, bool> hash = new Dictionary<char, bool>();

        for(int i = 0; i < s.Length; i++)
        {
            if(!hash.ContainsKey(s[i])) hash[s[i]] = true;
        }

        return hash.Keys.Count() < 26 ? false : true;
    }
}
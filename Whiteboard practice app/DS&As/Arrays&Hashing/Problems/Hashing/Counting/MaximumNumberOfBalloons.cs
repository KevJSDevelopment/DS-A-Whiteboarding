public class Balloons
{
    public int GetMaxNumber(string text)
    {
        Dictionary<char, int> charSetCount = new()
        {
            {'b',1}, 
            {'a', 1},
            {'l', 2},
            {'o', 2},
            {'n', 1}
        };

        Dictionary<char, int> charCounts = new();

        for(int i = 0; i < text.Length; i++)
        {
            if(charCounts.Keys.Contains(text[i])) charCounts[text[i]] += 1;
            else if(charSetCount.Keys.Contains(text[i])) charCounts[text[i]] = 1;
        }
        
        if(!charCounts.Keys.Contains('b') || !charCounts.Keys.Contains('a') || !charCounts.Keys.Contains('l') || !charCounts.Keys.Contains('o') || !charCounts.Keys.Contains('n')) return 0;
        if(charCounts['l'] == 1 || charCounts['o'] == 1) return 0;
        int minCount = charCounts['b'];

        foreach(char key in charCounts.Keys)
        {
            switch(key)
            {
                case 'a':
                    if(minCount > charCounts[key]) minCount = charCounts[key];
                    break;
                case 'l':
                    if(minCount > Math.Ceiling(charCounts[key] / 2.0)) minCount = charCounts[key] / 2;
                    break;
                case 'o':
                    if(minCount > Math.Ceiling(charCounts[key] / 2.0)) minCount = charCounts[key] / 2;
                    break;
                case 'n':
                    if(minCount > charCounts[key]) minCount = charCounts[key];
                    break;
            }
        }

        return minCount;
    }
}
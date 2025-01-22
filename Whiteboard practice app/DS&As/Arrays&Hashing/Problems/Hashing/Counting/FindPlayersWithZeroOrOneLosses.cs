public class Players
{
    public IList<IList<int>> GetPlayersWithOneOrLessLoss(int[][] matches)
    {
        Dictionary<int, int> lossCount = new();

        List<int> zeroLosses = new();
        List<int> oneLoss = new();

        for(int i = 0; i < matches.Length; i++)
        {
            if(!lossCount.Keys.Contains(matches[i][0])) lossCount[matches[i][0]] = 0;

            if(lossCount.Keys.Contains(matches[i][1])) lossCount[matches[i][1]] += 1;
            else lossCount[matches[i][1]] = 1;
        }

        foreach(int key in lossCount.Keys)
        {
            if(lossCount[key] == 0) zeroLosses.Add(key);
            else if (lossCount[key] == 1) oneLoss.Add(key);
        }
        zeroLosses.Sort();
        oneLoss.Sort();
        return new List<IList<int>>() { zeroLosses, oneLoss };
    }
}
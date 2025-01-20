public class CountingElements
{
    public int CountElements(int[] arr)
    {
        Dictionary<int, int> inArrayNumbers = new();

        for(int i = 0; i < arr.Length; i++)
        {
            if(inArrayNumbers.ContainsKey(arr[i])) inArrayNumbers[arr[i]] += 1;
            else inArrayNumbers[arr[i]] = 1;
        }

        int count = 0;

        foreach(int key in inArrayNumbers.Keys)
        {
            if(inArrayNumbers.Keys.Contains(key + 1)) 
            {
                count += inArrayNumbers[key];
            }
        }

        return count;
    }
}
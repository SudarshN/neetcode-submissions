public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        
        Dictionary<int,int> countDict = new Dictionary<int,int>();

        List<int>[] buckets = new List<int>[nums.Length + 1];

        foreach(int i in nums)
        {
            if(countDict.ContainsKey(i))
            {
                countDict[i]++;
            }
            else
            {
                countDict[i] = 1;
            }
        }

        foreach(KeyValuePair<int,int> kvp in countDict)
        {
            int freq = kvp.Value;
            int key = kvp.Key;

            if(buckets[freq] == null)
                buckets[freq] = new List<int>();
            
            buckets[freq].Add(key);
            
            
        }
        int[] result = new int[k];
        int index = 0;

        for(int freq = buckets.Length-1; freq>=0 &&index<k; freq--)
        {

            if(buckets[freq] == null) continue;

            foreach(int num in buckets[freq])
            {
                result[index++] = num;
                if(index == k) break;
            }
        }
        
        return result;
    }
}

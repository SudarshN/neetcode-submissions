public class Solution {
    public int[] TwoSum(int[] nums, int target) {
    
        if(nums.Length == 0) return new int[1];
        int[] result = new int[2];
        Dictionary<int,int> map = new Dictionary<int,int>();

        for(int i =0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if(!map.ContainsKey(complement))
            {
                map.Add(nums[i],i);
            }
            else
            {
                return new int[2]{map[complement],i};
                //result.Add(map[complement],i);
                //break;
            }
        }

        return result;
    }
}

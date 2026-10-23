public class Solution {
    public bool hasDuplicate(int[] nums) {
        Dictionary<int,int> _map = new Dictionary<int,int>();

        for(int i=0; i<nums.Length;i++){
            if(_map.ContainsKey(nums[i]))
                return true;

          _map.Add(nums[i],i);
        }
        return false;
    }
}

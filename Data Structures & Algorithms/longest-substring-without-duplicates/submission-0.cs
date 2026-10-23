public class Solution {
    public int LengthOfLongestSubstring(string s) {
        Dictionary<char, int> lastSeen = new Dictionary<char, int>();
        int left = 0;
        int maxLen = 0;

        for (int right = 0; right < s.Length; right++) 
        {
            char c = s[right];

            if(lastSeen.ContainsKey(c))
            {
                left = Math.Max(left,lastSeen[c]+1);
            }

            lastSeen[c] = right;
            maxLen = Math.Max(maxLen, right - left + 1);

        }
        return maxLen;

    }
}

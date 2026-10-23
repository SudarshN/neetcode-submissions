public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;
        Dictionary<char,int> _countMap = new Dictionary<char,int>();
        foreach(char c in t)
        {
            if(_countMap.ContainsKey(c))
                _countMap[c]++;
            else
                _countMap[c] = 1;
        }

        foreach(char c in s)
        {
            if(!t.Contains(c))
                return false;
            else
            _countMap[c]--;
        }
        foreach(KeyValuePair<char,int> kv in _countMap)
        {
            if(kv.Value != 0) return false;
        }
        return true;
    }
}

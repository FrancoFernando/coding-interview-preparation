public class Solution {
    public int RomanToInt(string s) {
        
        var symbolToValue = new Dictionary<char,int>{
            ['I'] = 1,
            ['V'] = 5,
            ['X'] = 10,
            ['L'] = 50,
            ['C'] = 100,
            ['D'] = 500,
            ['M'] = 1000
        };

        int ans = symbolToValue[s.Last()];

        for (int i = s.Length-2; i >= 0; --i) {

            if ((s[i] == 'I' && (s[i+1] == 'V' || s[i+1] == 'X')) ||
                (s[i] == 'X' && (s[i+1] == 'L' || s[i+1] == 'C')) ||
                (s[i] == 'C' && (s[i+1] == 'D' || s[i+1] == 'M'))) {
                ans -= symbolToValue[s[i]];
            }
            else {
                ans += symbolToValue[s[i]];
            }
        }

        return ans;
    }
}

// use the observation that a number need to be subtract only when placed befor a greater number
public class Solution {
    public int RomanToInt(string s) {
        
        var symbolToValue = new Dictionary<char,int>{
            ['I'] = 1,
            ['V'] = 5,
            ['X'] = 10,
            ['L'] = 50,
            ['C'] = 100,
            ['D'] = 500,
            ['M'] = 1000
        };

        int ans = symbolToValue[s.Last()];

        for (int i = s.Length-2; i >= 0; --i) {

            int currentValue = symbolToValue[s[i]];
            int nextValue = symbolToValue[s[i+1]];
            if (currentValue < nextValue) {
                ans -= symbolToValue[s[i]];
            }
            else {
                ans += symbolToValue[s[i]];
            }
        }

        return ans;
    }
}

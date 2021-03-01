class Solution {
public:
    int calculateTime(string keyboard, string word) {
        
        const int keyboardSize = keyboard.size();
        
        int charToKeyIndex[keyboardSize];
        for (int i = 0; i < keyboardSize; ++i) {
            charToKeyIndex[keyboard[i]-'a'] = i;
        }
        
        int prevCharIndex = 0, time = 0;
        for (char c : word) {
            time += abs(charToKeyIndex[c-'a']-prevCharIndex);
            prevCharIndex = charToKeyIndex[c-'a'];
        }
        return time;
    }
};
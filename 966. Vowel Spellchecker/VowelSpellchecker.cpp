class Solution {
    
    string removeVowels(string const& s) {
        
        string out;
        
        for (char c : s) {
            if (c != 'a' && c != 'e' && c != 'i' && c != 'o' && c != 'u') {
                out.push_back(c);
            }
            else {
                out.push_back('*');
            }
        }
        return out;
    }
    
public:
    vector<string> spellchecker(vector<string>& wordlist, vector<string>& queries) {
        
        vector<string> ans;  
        unordered_set<string> words;  //fast lookup if it here return
        unordered_map<string,int> lowerToWord;//map lower unique rep to index; transform query to lower to use
        unordered_map<string,int> consonantToWord;//map consonant only rep to index
        
        for (int i = 0; i < wordlist.size(); ++i) {
            
            words.insert(wordlist[i]);
            
            string lowerWord = wordlist[i];
            transform(wordlist[i].begin(), wordlist[i].end(), lowerWord.begin(), [](auto c){ 
                return tolower(c); 
            });
            if (lowerToWord.count(lowerWord) == 0) lowerToWord[lowerWord] = i;
            
            string consonantWord = removeVowels(lowerWord);
            if (consonantToWord.count(consonantWord) == 0) consonantToWord[consonantWord] = i;
        }
        
        for (string& query : queries) {
            
            if (words.count(query) > 0) {
                ans.push_back(query);
            }
            else {
                string lowerQuery = query;
                transform(query.begin(), query.end(), lowerQuery.begin(), [](auto c){ 
                    return tolower(c); 
                });
                if (lowerToWord.count(lowerQuery) > 0) {
                    ans.push_back(wordlist[lowerToWord[lowerQuery]]);
                }
                else {
                    string consonantQuery = removeVowels(lowerQuery);
                    if (consonantToWord.count(consonantQuery) > 0) {
                        ans.push_back(wordlist[consonantToWord[consonantQuery]]);
                    }
                    else {
                        ans.push_back("");
                    }
                }
            }
        }
        
        return ans;
    }
};
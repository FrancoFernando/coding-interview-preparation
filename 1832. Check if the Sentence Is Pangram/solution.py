class Solution:
    def checkIfPangram(self, sentence: str) -> bool:

        isCharUsed = [False]*26
        
        for c in sentence:
            isCharUsed[ord(c)-ord('a')] = True
        
        return all(flag is True for flag in isCharUsed)
        #return len (set (sentence)) == 26 one liner using set

class Solution:
    
    def hasEvenDigits(self, num: int) -> bool:
        
        digits = 0
        
        while num > 0:
            num //= 10
            digits +=1
            
        return digits % 2 == 0
    
    def findNumbers(self, nums: List[int]) -> int:
        
        evenDigitsNumbers = 0
        
        for num in nums:
            if self.hasEvenDigits(num):
                evenDigitsNumbers += 1
        
        return evenDigitsNumbers
    
    ''' 
    def findNumbers(self, nums: List[int]) -> int:
        
        evenDigitsNumbers = 0
        
        for num in nums:
            if len(str(num)) % 2 == 0:
                evenDigitsNumbers += 1
        
        return evenDigitsNumbers
    '''   
                

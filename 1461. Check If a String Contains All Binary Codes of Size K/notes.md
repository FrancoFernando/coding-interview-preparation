# Thinking Process

1. The key observations are that 1)only substrings of length k need to be checked 2) there are exactly 2^k binary codes of length k. From 1 -> a sliding window technique can be used to check all substring. From 2 -> if 2^k different substring are found answer is true otherwise false. Next observation to improve speed and complexity is that from one window to the next one onlt the first and last char changes. This make thing to rolling hash technique. Considering int instead of strings it easy to calculate the value corresponding to a substring from the value corresponding to the substring of the previous window.

# Complexity

* O(N) time to traverse all the string (values are computed in O(1) with rolling hash
* O(N) space to store if a value has been found or not (vector of bit could perform better than a set) 



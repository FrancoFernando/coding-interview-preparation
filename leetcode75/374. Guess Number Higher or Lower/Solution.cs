/** 
 * Forward declaration of guess API.
 * @param  num   your guess
 * @return 	     -1 if num is higher than the picked number
 *			      1 if num is lower than the picked number
 *               otherwise return 0
 * int guess(int num);
 */

public class Solution : GuessGame {
    public int GuessNumber(int n) {

        int left = 1, right = n;
        
        while (left <= right) {
            int mid = left + (right - left) / 2;
            int answer = guess(mid);
            if (answer < 0) { 
                right = mid-1;
            }
            else if (answer > 0) { 
                left  = mid+1;
            }
            else {
                return mid;
            }
        }
        
        //should never reach this point
        return -1;
    }
}

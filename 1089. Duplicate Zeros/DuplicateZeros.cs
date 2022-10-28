public class Solution {
    public void DuplicateZeros(int[] arr) {
        
        int shift = arr.Count(x => x == 0);
        
        for (int i = arr.Length-1; i >= 0; --i) {

            if (arr[i] == 0) {

                shift--;
                //duplicate the zero
                if (i+shift+1 < arr.Length) {
                    arr[i+shift+1] = 0;
                }
            }

            if (i+shift < arr.Length) {
                arr[i+shift] = arr[i];
            }
        }
    }
}

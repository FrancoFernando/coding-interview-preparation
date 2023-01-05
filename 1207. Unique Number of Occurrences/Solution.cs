//Only array
public class Solution {
    public bool UniqueOccurrences(int[] arr) {
        
        const int NumberRangeSize = 2001;
        const int PositiveNumberRangeSize = 1000;
        const int MaxArraySize = 1000;
        var numberOccurrences = new int[NumberRangeSize];

        foreach (int num in arr) {

            int index = (num >= 0) ? num : Math.Abs(num) + PositiveNumberRangeSize;
            numberOccurrences[index]++;
        }

        var occurencesSet = new bool[MaxArraySize+1];

        foreach (int occurrency in numberOccurrences) {
            if (occurrency != 0 && occurencesSet[occurrency]) return false;
            occurencesSet[occurrency] = true;
        }

        return true;
    }
}

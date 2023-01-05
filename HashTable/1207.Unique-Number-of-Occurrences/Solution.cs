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

//With Dictionar/set
public class Solution {
    public bool UniqueOccurrences(int[] arr) {
        
        var numToOccurrency = new Dictionary<int,int>();

        foreach (int num in arr) {
            numToOccurrency.TryGetValue(num, out var count); 
            numToOccurrency[num] = count + 1;      
            //if (numberOccurrences.ContainsKey(num)) numberOccurrences[num]++;
            //else numberOccurrences[num] = 1;
        }

        var occurencesSet = new HashSet<int>();

        foreach (int occurrency in numToOccurrency.Values) {
            if (occurrency != 0 && occurencesSet.Contains(occurrency)) return false;
            occurencesSet.Add(occurrency);
        }

        return true;
    }
}

//With LINQ
//nice but inefficient
public class Solution {
    public bool UniqueOccurrences(int[] arr) {
        
        return arr.GroupBy(n => n) // group all equal numbers together
            .Select(n => n.Count()) // count occurrency of each group
            .Distinct() // extract distinct occurencies
            .Count() == arr.Distinct().Count(); // count distinct occurrencies and compare with distinct numbers
    }
}

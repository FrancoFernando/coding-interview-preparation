public class Solution {
    public int NumRescueBoats(int[] people, int limit) {
        
        Array.Sort(people);

        int boats = 0;

        for (int l = 0, r = people.Length-1; l <= r; r--) {
            if (people[r] + people[l] <= limit) l++;
            boats++;
        }

        return boats;
    }
}

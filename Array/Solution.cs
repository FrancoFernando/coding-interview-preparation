public class Solution {
    public double Average(int[] salary) {
        
        int minSalary = salary.Min();
        int maxSalary = salary.Max();
        int salarySum = salary.Sum();
        return (salarySum-minSalary-maxSalary) / (double)(salary.Length-2);
    }
}

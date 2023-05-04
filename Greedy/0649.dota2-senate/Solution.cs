public class Solution {

    public string PredictPartyVictory(string senate) {

        var radiantSenators = new Queue<int>();
        var direSenators = new Queue<int>();

        int numberOfSenators = senate.Length;

        for(int i = 0; i < numberOfSenators; i++){
            if (senate[i] == 'R') radiantSenators.Enqueue(i);
            else direSenators.Enqueue(i);
        }

        while(radiantSenators.Count() > 0 && direSenators.Count() > 0){

            int radiantSenatorIndex = radiantSenators.Dequeue();
            int direSenatorIndex = direSenators.Dequeue();
            if(radiantSenatorIndex < direSenatorIndex) {
                radiantSenators.Enqueue(radiantSenatorIndex + numberOfSenators);
            } 
            else {
                direSenators.Enqueue(direSenatorIndex + numberOfSenators);
            }
        }
        return radiantSenators.Count > 0 ? "Radiant" : "Dire";
    }
}

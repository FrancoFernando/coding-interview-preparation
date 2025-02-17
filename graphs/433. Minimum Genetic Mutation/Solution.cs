public class Solution {
    private static readonly char[] Choices = {'A', 'C', 'G', 'T'};
    public int MinMutation(string startGene, string endGene, string[] bank) {

        if (!bank.Contains(endGene)) return -1;
        
		int mutations = 0;
		var queue = new Queue<string>();
		queue.Enqueue(startGene);
		var discovered = new HashSet<string>();
		discovered.Add(startGene);
		
		while (queue.Count > 0) {
			int levelSize = queue.Count;
			for (int i = 0; i < levelSize; i++) {
				var currentGene = queue.Dequeue();
				if (currentGene == endGene) {
					return mutations;
				}
				foreach (var gene in FindValidMutations(currentGene, bank, discovered)) {				
                    discovered.Add(gene);
                    queue.Enqueue(gene);
				}
			}
			mutations++;
		}
		return -1;
    }
	
		private List<string> FindValidMutations(string gene, string[] bank, HashSet<string> discovered){
            var mutations = new List<string>();
            char[] geneArray = gene.ToCharArray();
            for (int i = 0; i < geneArray.Length; i++) {
            var originalChar = geneArray[i];
                foreach (char c in Choices) {
                    if (c != originalChar) {
                        geneArray[i] = c;
                        var newGene = new string(geneArray);
                        if (bank.Contains(newGene) && !discovered.Contains(newGene)) {
                            mutations.Add(newGene);
                        }
                    }
                }
                geneArray[i] = originalChar;
            }
            return mutations;
        }
}

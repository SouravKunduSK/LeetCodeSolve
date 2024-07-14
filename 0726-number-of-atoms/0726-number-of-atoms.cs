public class Solution {
    public string CountOfAtoms(string formula) {
        int i = 0;
        int n = formula.Length;
        Stack<Dictionary<string, int>> stack = new Stack<Dictionary<string, int>>();
        stack.Push(new Dictionary<string, int>());

        while (i < n) {
            char c = formula[i];

            if (c == '(') {
                stack.Push(new Dictionary<string, int>());
                i++;
            } else if (c == ')') {
                i++;
                int start = i;
                while (i < n && char.IsDigit(formula[i])) i++;
                int multiplicity = start < i ? int.Parse(formula.Substring(start, i - start)) : 1;

                var top = stack.Pop();
                var current = stack.Peek();

                foreach (var kv in top) {
                    if (current.ContainsKey(kv.Key)) {
                        current[kv.Key] += kv.Value * multiplicity;
                    } else {
                        current[kv.Key] = kv.Value * multiplicity;
                    }
                }
            } else {
                int start = i;
                i++;
                while (i < n && char.IsLower(formula[i])) i++;
                string name = formula.Substring(start, i - start);

                start = i;
                while (i < n && char.IsDigit(formula[i])) i++;
                int multiplicity = start < i ? int.Parse(formula.Substring(start, i - start)) : 1;

                var current = stack.Peek();
                if (current.ContainsKey(name)) {
                    current[name] += multiplicity;
                } else {
                    current[name] = multiplicity;
                }
            }
        }

        var resultDict = stack.Pop();
        var sortedResult = resultDict.OrderBy(x => x.Key);
        StringBuilder result = new StringBuilder();
        foreach (var kv in sortedResult) {
            result.Append(kv.Key);
            if (kv.Value > 1) {
                result.Append(kv.Value);
            }
        }

        return result.ToString();

    }
}
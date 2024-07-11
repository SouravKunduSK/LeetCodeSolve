public class Solution {
    public string ReverseParentheses(string s) {
         Stack<char> stack = new Stack<char>();
        
        foreach (char ch in s) {
            if (ch == ')') {
                var queue = new Queue<char>();
                while (stack.Peek() != '(') {
                    queue.Enqueue(stack.Pop());
                }
                stack.Pop(); 
                while (queue.Count > 0) {
                    stack.Push(queue.Dequeue());
                }
            } else {
                stack.Push(ch);
            }
        }
       
        return new string(stack.Reverse().ToArray());
    }
}
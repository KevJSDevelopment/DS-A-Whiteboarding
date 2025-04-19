/* 
Evaluate Reverse Polish Notation
You are given an array of strings tokens that represents a valid arithmetic expression in Reverse Polish Notation.

Return the integer that represents the evaluation of the expression.

The operands may be integers or the results of other operations.
The operators include '+', '-', '*', and '/'.
Assume that division between integers always truncates toward zero.
Example 1:

Input: tokens = ["1","2","+","3","*","4","-"]

Output: 5

Explanation: ((1 + 2) * 3) - 4 = 5
Constraints:

1 <= tokens.length <= 1000.
tokens[i] is "+", "-", "*", or "/", or a string representing an integer in the range [-100, 100].
*/

public class Solution {
    public int EvalRPN(string[] tokens) {
        
        Stack<int> numStack = new Stack<int>();

        foreach(string token in tokens)
        {   
            bool isNumeric = int.TryParse(token, out int n);
            if(isNumeric) numStack.Push(n);
            else 
            {
                int num1 = numStack.Pop();
                int num2 = numStack.Pop();
                switch(token) {
                    case "+":
                        numStack.Push(num2 + num1);
                        break;
                    case "-":
                        numStack.Push(num2 - num1);
                        break;
                    case "*":
                        numStack.Push(num2 * num1);
                        break;
                    case "/":
                        numStack.Push(num2 / num1);
                        break;
                    case "%":
                        numStack.Push(num2 % num1);
                        break;
                    default:
                        Console.WriteLine("Token not found");
                        break;
                }
            }
        }
        return numStack.First();
    }
}

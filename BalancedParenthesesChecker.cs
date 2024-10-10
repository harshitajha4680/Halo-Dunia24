using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter an expression:");
        string expression = Console.ReadLine();
        
        if (AreParenthesesBalanced(expression))
        {
            Console.WriteLine("The parentheses are balanced.");
        }
        else
        {
            Console.WriteLine("The parentheses are not balanced.");
        }
    }

    static bool AreParenthesesBalanced(string expression)
    {
        Stack<char> stack = new Stack<char>();

        foreach (char ch in expression)
        {
            // Push opening brackets onto the stack
            if (ch == '{' || ch == '(' || ch == '[')
            {
                stack.Push(ch);
            }
            // Check for closing brackets
            else if (ch == '}' || ch == ')' || ch == ']')
            {
                // If stack is empty or top of the stack doesn't match
                if (stack.Count == 0 || !IsMatchingPair(stack.Pop(), ch))
                {
                    return false;
                }
            }
        }

        // Check if stack is empty at the end
        return stack.Count == 0;
    }

    static bool IsMatchingPair(char opening, char closing)
    {
        return (opening == '{' && closing == '}') ||
               (opening == '(' && closing == ')') ||
               (opening == '[' && closing == ']');
    }
}

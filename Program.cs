using System.Collections;

namespace infix_to_postfix
{
    public class Program
    {
        public static int[] stack = new int[100];
        public static int sp = -1;
        
        public static void Main()
        {
            PostfixCalculation();
        }
        
        public static void InfixToPostfix()
        {
            string postfix = "";
            string infix = "A+B*C/D-F+H";
            string operators = "$+-*/()";
            int[] precedence =
            {
                0, 2, 2, 3, 3, 1, 1
            };
            
            Push('$');

            for (int i = 0; i < infix.Length; i++)
            {
                int index = operators.IndexOf(infix[i]);
                
                // If it's an operand, add it directly to postfix.
                if (index == -1)
                {
                    postfix += infix[i];
                    continue;
                }

                // If it's '(', push it directly to the stack.
                if (infix[i] == '(')
                {
                    Push(infix[i]);
                    continue;
                }

                // If it's ')', pop until '(' is found.
                if (infix[i] == ')')
                {
                    while ((char)Peek() != '(')
                    {
                        postfix += (char)Pop();
                    }

                    Pop(); // '(' is popped from the stack.
                    continue;
                }

                // If the operator in infix is of higher precedence, push it to the stack.
                if (precedence[index] > precedence[operators.IndexOf((char)Peek())])
                {
                    Push(infix[i]);
                }
                
                // Otherwise, pop from the stack until the top operator has lower precedence and add to postfix.
                else
                {
                    while (precedence[index] <= precedence[operators.IndexOf((char)Peek())])
                    {
                        postfix += (char)Pop();
                    }
                    
                    // Finally, push the current operator from infix to the stack.
                    Push(infix[i]);
                }
            }

            while (StackCount() > 1)
            {
                // After reading the infix expression, if operators are left in the stack, pop them until the stack is empty.
                postfix += (char)Pop();
            }

            Pop();
            
            Console.WriteLine(infix);
            Console.WriteLine(postfix);

        }

        public static void PostfixCalculation()
        {
            string postfix = "121+-";
            string operators = "+-/*";

            for (int i = 0; i < postfix.Length; i++)
            {
                if (operators.IndexOf(postfix[i]) == -1 )
                {
                    Push(postfix[i] - '0');
                    continue;
                }

                int number1 = Pop();
                int number2 = Pop();
                int result = 0;

                if (postfix[i] == '+')
                {
                    result = number2 + number1;
                    Push(result);
                }
                if (postfix[i] == '-')
                {
                    result = number2 - number1;
                    Push(result);
                }
                if (postfix[i] == '*')
                {
                    result = number2 * number1;
                    Push(result);
                }
                if (postfix[i] == '/')
                {
                    result = number2 / number1;
                    Push(result);
                }
            }
            
            Console.WriteLine(Pop());
        }
        
        public static void Push(int data)
        {
            // Push an element to the stack.
            
            if (sp == stack.Length - 1)
            {
                return;
            }

            sp++;
            stack[sp] = data;
        }

        public static int Pop()
        {
            // Pop the top element from the stack and return it.
            int data = stack[sp];
            sp--;
            return data;
        }

        public static int StackCount()
        {
            // Return the number of elements in the stack.
            
            return sp + 1;
        }

        public static int Peek()
        {
            // Return the top element of the stack.
            
            return stack[sp];
        }
        
    }
}

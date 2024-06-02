using System.Text;

// Static class for evaluating expressions in Reverse Polish Notation (RPN)
static class RPN
{
    // Method to evaluate infix expression
    public static double Evaluate(string input)
    {
        try
        {
            // Convert infix to postfix and evaluate the result
            return EvaluatePostfix(InfixToPostfix(input));
        }
        catch (Exception ex)
        {
            // If any exception occurs, wrap it in ArgumentException with a custom message
            throw new ArgumentException("Invalid input expression.", ex);
        }
    }

    // Method to evaluate postfix expression
    private static double EvaluatePostfix(string input)
    {
        // Tokenize the postfix expression
        string[] tokens = Tokenizer.Tokenize(input);
        // Stack to store operands during evaluation
        Stack<double> stack = new Stack<double>();

        foreach (string token in tokens)
        {
            // Check if token is a numeric value
            if (double.TryParse(token, out double number))
            {
                // Push numeric value onto the stack
                stack.Push(number);
            }
            // Check if token is an operator
            else if (IsOperator(token))
            {
                // Ensure there are enough operands on the stack for the operation
                if (stack.Count < 2)
                    throw new InvalidOperationException("Insufficient operands.");

                // Pop two operands from the stack
                double n2 = stack.Pop();
                double n1 = stack.Pop();

                // Perform the operation based on the operator
                stack.Push(token switch
                {
                    "+" => n1 + n2,
                    "-" => n1 - n2,
                    "*" => n1 * n2,
                    "/" => n1 / n2,
                    "^" => Math.Pow(n1, n2),
                    _ => throw new InvalidOperationException("Unsupported operator.")
                });
            }
            else
            {
                // Throw exception for invalid token
                throw new ArgumentException($"Invalid token: {token}");
            }
        }

        // After evaluation, there should be only one value left on the stack, which is the result
        if (stack.Count != 1)
            throw new InvalidOperationException("The input has too many operands.");

        // Return the final result
        return stack.Pop();
    }

    // Method to convert infix expression to postfix (based on shunting yard algorithm)
    private static string InfixToPostfix(string input)
    {
        // Tokenize the infix expression
        string[] tokens = Tokenizer.Tokenize(input);
        // StringBuilder to store the postfix expression
        StringBuilder output = new StringBuilder();
        // Stack to store operators during conversion
        Stack<string> operators = new Stack<string>();
        // Flag to track if the previous token was an operator
        bool previousWasOperator = true;

        foreach (string token in tokens)
        {
            // Check if token is a numeric value
            if (double.TryParse(token, out _))
            {
                // Append numeric value to the output with a space separator
                output.Append(token).Append(' ');
                previousWasOperator = false;
            }
            // Check if token is an operator
            else if (IsOperator(token))
            {
                // If the token is a minus sign and the previous token was an operator, add a zero before it
                if (token == "-" && previousWasOperator)
                {
                    output.Append("0 ");
                }

                // Pop operators with higher or equal precedence from the stack and append them to the output
                while (operators.Count > 0 && GetOperatorPrecedence(operators.Peek()) >= GetOperatorPrecedence(token) && operators.Peek() != "(")
                {
                    output.Append(operators.Pop()).Append(' ');
                }
                // Push the current operator onto the stack
                operators.Push(token);
                previousWasOperator = true;
            }
            else if (token == "(")
            {
                // Push opening parenthesis onto the stack
                operators.Push(token);
                previousWasOperator = true;
            }
            else if (token == ")")
            {
                // Pop operators from the stack and append them to the output until an opening parenthesis is found
                while (operators.Count > 0 && operators.Peek() != "(")
                {
                    output.Append(operators.Pop()).Append(' ');
                }
                // If no opening parenthesis is found, throw an exception
                if (operators.Count == 0)
                    throw new ArgumentException("Mismatched parentheses.");
                // Pop the opening parenthesis from the stack
                operators.Pop();
                previousWasOperator = false;
            }
            else
            {
                // Throw exception for invalid token
                throw new ArgumentException($"Invalid token: {token}");
            }
        }

        // Append remaining operators from the stack to the output
        while (operators.Count > 0)
        {
            string op = operators.Pop();
            // If an opening parenthesis is encountered, throw an exception
            if (op == "(")
                throw new ArgumentException("Mismatched parentheses.");
            output.Append(op).Append(' ');
        }

        // Return the postfix expression as a string
        return output.ToString().Trim();
    }

    // Method to get the precedence level of an operator
    private static int GetOperatorPrecedence(string op)
    {
        // Assign precedence levels to operators
        return op switch
        {
            "+" or "-" => 1,
            "*" or "/" => 2,
            "^" => 3,
            _ => -1
        };
    }

    // Method to check if a token is an operator
    private static bool IsOperator(string token)
    {
        // Check if the token is one of the supported operators
        return token switch
        {
            "+" or "-" or "*" or "/" or "^" => true,
            _ => false
        };
    }
}

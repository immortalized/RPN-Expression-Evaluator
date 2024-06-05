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
            throw new ArgumentException($"Invalid input expression. {ex.Message}");
        }
    }

    // Method to evaluate postfix expression
    private static double EvaluatePostfix(string input)
    {
        // Tokenize the postfix expression
        string[] tokens = Tokenizer.Tokenize(input);
        // Stack to store operands during evaluation
        Stack<double> operands = new Stack<double>();

        foreach (string token in tokens)
        {
            // Check if token is a numeric value
            if (double.TryParse(token, out double number))
            {
                // Push numeric value onto the stack
                operands.Push(number);
            }
            // Check if token is a function
            else if (IsFunction(token))
            {
                //Pop one operand from the stack
                double n = operands.Pop();

                // Perform the operation based on the function
                operands.Push(token switch
                {
                    "sqrt" => Math.Sqrt(n),
                    "sin" => Math.Sin(n * Math.PI / 180.0),
                    "cos" => Math.Cos(n * Math.PI / 180.0),
                    "tan" => Math.Tan(n * Math.PI / 180.0),
                    "sinh" => Math.Sinh(n),
                    "cosh" => Math.Cosh(n),
                    "tanh" => Math.Tanh(n),
                    "exp" => Math.Exp(n),
                    "log" => Math.Log10(n),
                    "lg" => Math.Log2(n),
                    "ln" => Math.Log(Math.E, n),
                    _ => throw new InvalidOperationException("Unsupported function.")
                });
            }
            // Check if token is an operator
            else if (IsOperator(token))
            {
                // Ensure there are enough operands on the stack for the operation
                if (operands.Count < 1)
                    throw new InvalidOperationException("Insufficient operands.");

                // Perform the operation based on the operator
                if (token == "!")
                {
                    double n = operands.Pop();
                    operands.Push(Factorial(n));
                }
                else
                {
                    // Ensure there are enough operands on the stack for the operation
                    if (operands.Count < 2)
                        throw new InvalidOperationException("Insufficient operands.");

                    double n2 = operands.Pop();
                    double n1 = operands.Pop();

                    operands.Push(token switch
                    {
                        "+" => n1 + n2,
                        "-" => n1 - n2,
                        "*" => n1 * n2,
                        "/" => n1 / n2,
                        "^" => Math.Pow(n1, n2),
                        _ => throw new InvalidOperationException("Unsupported operator.")
                    });
                }
            }
            else
            {
                // Throw exception for invalid token
                throw new ArgumentException($"Invalid token: {token}");
            }
        }

        // After evaluation, there should be only one value left on the stack, which is the result
        if (operands.Count != 1)
            throw new InvalidOperationException("The input has too many operands.");

        // Return the final result
        return operands.Pop();
    }

    // Method to convert infix expression to postfix (based on shunting yard algorithm)
    private static string InfixToPostfix(string input)
    {
        // Tokenize the infix expression
        string[] tokens = HandleConstants(Tokenizer.Tokenize(input));
        // StringBuilder to store the postfix expression
        StringBuilder output = new StringBuilder();
        // Stack to store operators during conversion
        Stack<string> operators = new Stack<string>();
        // Flag to track if the previous token was an operator
        bool previousWasOperator = true;
        bool shouldBeNegative = false;

        foreach (string token in tokens)
        {
            // Check if token is a numeric value
            if (double.TryParse(token, out _))
            {
                if(shouldBeNegative)
                {
                    output.Append(token).Append(' ').Append("- ");
                    operators.Pop();
                    shouldBeNegative = false;
                } else
                {
                    // Append numeric value to the output with a space separator
                    output.Append(token).Append(' ');
                }

                previousWasOperator = false;
            }
            else if (IsFunction(token))
            {
                operators.Push(token);
            }
            // Check if token is an operator
            else if (IsOperator(token))
            {
                // Pop operators with higher or equal precedence from the stack and append them to the output
                while (operators.Count > 0 && GetOperatorPrecedence(operators.Peek()) >= GetOperatorPrecedence(token) && operators.Peek() != "(")
                {
                    output.Append(operators.Pop()).Append(' ');
                }
                
                // If the token is a minus sign and the previous token was an operator, add a zero before it
                if (token == "-" && previousWasOperator)
                {
                    output.Append("0 ");
                    shouldBeNegative = true;
                }
                
                //Only set to true when token is binary operator
                if(token != "!")
                    previousWasOperator = true;

                // Push the current operator onto the stack
                operators.Push(token);
            }
            else if (token == "(")
            {
                // Push opening parenthesis onto the stack
                operators.Push(token);
                shouldBeNegative = false;
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

                //Check if there's a function in the stack
                if (operators.Count > 0 && IsFunction(operators.Peek()))
                    //If there is append it to the output
                    output.Append(operators.Pop()).Append(' ');

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

    private static double Factorial(double n)
    {
        if (n < 0 || !int.TryParse(n.ToString(), out _))
            throw new ArgumentException("Factorial is not defined for negative numbers or non-integers.");

        if (n == 0 || n == 1)
            return 1;

        double result = 1;
        for (int i = 2; i <= n; i++)
        {
            result *= i;
        }

        return result;
    }

    //Method to replace constants to their value
    private static string[] HandleConstants(string[] tokens)
    {
        for (int i = 0; i < tokens.Length; i++)
        {
            tokens[i] = (tokens[i] switch{
                "pi" => Math.PI.ToString(),
                "e" => Math.E.ToString(),
                _ => tokens[i]
            });
        }

        return tokens;
    }

    // Method to check if a token is a function
    private static bool IsFunction(string token)
    {
        // Check if the token is one of the supported functions
        return token switch
        {
            "sqrt" or "sin" or "cos" or "tan" or "sinh" or "cosh" or "tanh" or "exp" or "log" or "lg" or "ln" => true,
            _ => false
        };
    }

    // Method to get the precedence level of an operator
    private static int GetOperatorPrecedence(string op)
    {
        // Assign precedence levels to operators
        return op switch
        {
            "+" or "-" => 1,
            "*" or "/" => 2,
            "^" or "!" => 3,
            _ => -1
        };
    }

    // Method to check if a token is an operator
    private static bool IsOperator(string token)
    {
        // Check if the token is one of the supported operators
        return token switch
        {
            "+" or "-" or "*" or "/" or "^" or "!" => true,
            _ => false
        };
    }
}

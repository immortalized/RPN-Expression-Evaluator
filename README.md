# Reverse Polish Notation (RPN) Expression Evaluator

This is a simple C# implementation of an expression evaluator using the Reverse Polish Notation (RPN).

## Usage

1. Include the `RPN.cs` file in your project.
2. Call the `RPN.Evaluate()` method with an infix expression as input to obtain the result.

Example:

```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        string infixExpression = "2 + 3 * (4 - 1)";
        double result = RPN.Evaluate(infixExpression);
        Console.WriteLine($"Result: {result}");
    }
}
```

##Test

- The algorithm wasn't submitted to intense testing, but it did pass a basic test put together by ChatGPT.

<details>
    <summary>
        Results
    </summary>
    details
</details>

## Acknowledgments

- Thanks to the contributors of the Stack Overflow community for their valuable insights and solutions.
- Also thanks to ChatGPT for the error handling and documentation :D

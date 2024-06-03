# Reverse Polish Notation (RPN) Expression Evaluator 🧮

[![ ](https://img.shields.io/badge/-csharp-00D400?labelColor=gray&style=for-the-badge&logo=csharp&logoColor=00D400&logoWidth=20&link=https://learn.microsoft.com/en-us/dotnet/csharp/)](https://learn.microsoft.com/en-us/dotnet/csharp/)
[![ ](https://img.shields.io/badge/-.NET-A658FF?labelColor=gray&style=for-the-badge&logo=.net&logoColor=A658FF&logoWidth=20&link=https://dotnet.microsoft.com/en-us/)](https://dotnet.microsoft.com/en-us/)

This is a simple C# implementation of an expression evaluator using the Reverse Polish Notation (RPN).

## Usage 🚀

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

## Testing 🧪

- The algorithm wasn't submitted to intense testing, but it did pass a basic test put together by ChatGPT.

### Results
```diff
+ Expression 'sin(0.5)' is correct. Expected: 0.008726535498373935, Actual: 0.008726535498373935
+ Expression 'cos(0.5)' is correct. Expected: 0.9999619230641713, Actual: 0.9999619230641713
+ Expression 'tan(1)' is correct. Expected: 0.017455064928217585, Actual: 0.017455064928217585
+ Expression 'exp(1)' is correct. Expected: 2.7182818285, Actual: 2.718281828459045
+ Expression 'log(e)' is correct. Expected: 1, Actual: 1
+ Expression 'log(10)' is correct. Expected: 2.302585093, Actual: 2.302585092994046
+ Expression 'sqrt(4)' is correct. Expected: 2, Actual: 2
+ Expression 'pi' is correct. Expected: 3.1415926536, Actual: 3.141592653589793
+ Expression 'e' is correct. Expected: 2.7182818285, Actual: 2.718281828459045
+ Expression 'sin(pi / 2)' is correct. Expected: 0.02741213359204429, Actual: 0.02741213359204429
+ Expression 'cos(0)' is correct. Expected: 1, Actual: 1
+ Expression 'tan(pi / 4)' is correct. Expected: 0.013708642534394053, Actual: 0.013708642534394053
+ Expression 'exp(2)' is correct. Expected: 7.3890560989, Actual: 7.38905609893065
+ Expression 'log(1)' is correct. Expected: 0, Actual: 0
+ Expression 'sqrt(16)' is correct. Expected: 4, Actual: 4
+ Expression 'pi ^ 2' is correct. Expected: 9.8696044011, Actual: 9.869604401089358
+ Expression 'e ^ 2' is correct. Expected: 7.3890560989, Actual: 7.3890560989306495
+ Expression 'sin(0.5) + 5! * pi' is correct. Expected: 376.99984496627354, Actual: 376.99984496627354
+ Expression 'cos(0) * 10' is correct. Expected: 10, Actual: 10
+ Expression 'log(10) * e' is correct. Expected: 6.259112933, Actual: 6.259075216766395
+ Expression 'sqrt(25) + pi' is correct. Expected: 8.1415926536, Actual: 8.141592653589793
+ Expression 'pi / e' is correct. Expected: 1.1557273498, Actual: 1.1557273497909217
+ Expression 'exp(1) + sin(1)' is correct. Expected: 2.7357342348963285, Actual: 2.7357342348963285
+ Expression 'log(100) / 2' is correct. Expected: 2.302585093, Actual: 2.302585092994046
+ Expression 'pi * 3 - sqrt(9)' is correct. Expected: 6.4247779608, Actual: 6.424777960769379
+ Expression 'e ^ 3' is correct. Expected: 20.0855369232, Actual: 20.085536923187664
+ Expression 'cos(pi)' is correct. Expected: 0.9984971498638638, Actual: 0.9984971498638638
+ Expression 'tan(pi / 6)' is correct. Expected: 0.009138776996012258, Actual: 0.009138776996012258
+ Expression 'exp(0)' is correct. Expected: 1, Actual: 1
+ Expression 'log(2.7182818285)' is correct. Expected: 1, Actual: 1.0000000000150664
+ Expression 'sqrt(pi)' is correct. Expected: 1.7724538509, Actual: 1.7724538509055159
+ Expression 'sin(1) * cos(1)' is correct. Expected: 0.017449748351250485, Actual: 0.017449748351250485
+ Expression 'pi + e' is correct. Expected: 5.8598744821, Actual: 5.859874482048838
+ Expression 'e - 1' is correct. Expected: 1.7182818285, Actual: 1.718281828459045
+ Expression 'pi / 2' is correct. Expected: 1.5707963268, Actual: 1.5707963267948966
+ Expression 'e ^ 0.5' is correct. Expected: 1.6487212707, Actual: 1.6487212707001282
! Total correct expressions: 36/36
```

## Acknowledgments 🙏

- Thanks to the contributors of the Stack Overflow community for their valuable insights and solutions.
- Also thanks to ChatGPT for the error handling and documentation 😄

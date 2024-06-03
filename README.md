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

- The algorithm wasn't submitted to intense testing, but it did pass a basic test including edge cases and harder expressions.

### Results

<details>
  <summary>
    Results
  </summary>
    
```diff
+ Expression '5! + 3!' is correct. Expected: 126, Actual: 126
+ Expression 'sqrt(16) + exp(1)' is correct. Expected: 6.718281828459045, Actual: 6.718281828459045
+ Expression 'cos(pi/3) * 2^3' is correct. Expected: 7.998663835673038, Actual: 7.998663835673038
+ Expression 'sin(pi/6) + 3^2' is correct. Expected: 9.009138395397176, Actual: 9.009138395397176
+ Expression '7! / 5!' is correct. Expected: 42, Actual: 42
+ Expression '2^3 + sqrt(81)' is correct. Expected: 17, Actual: 17
+ Expression 'exp(2) - 4!' is correct. Expected: -16.610943901069348, Actual: -16.610943901069348
+ Expression 'sqrt(25) + cos(pi)' is correct. Expected: 5.998497149863864, Actual: 5.998497149863864
+ Expression '10! / 8!' is correct. Expected: 90, Actual: 90
+ Expression 'exp(1) * 5!' is correct. Expected: 326.1938194150854, Actual: 326.1938194150854
+ Expression '3! * sqrt(49)' is correct. Expected: 42, Actual: 42
+ Expression 'cos(pi/4) + 2^5' is correct. Expected: 32.99990604980155, Actual: 32.99990604980155
+ Expression 'sqrt(100) - 2!' is correct. Expected: 8, Actual: 8
+ Expression '4! * cos(pi/3)' is correct. Expected: 23.995991507019113, Actual: 23.995991507019113
+ Expression '2^4 / exp(1)' is correct. Expected: 5.886071058743077, Actual: 5.886071058743077
+ Expression '5! + sin(pi/2)' is correct. Expected: 120.02741213359205, Actual: 120.02741213359205
+ Expression 'sqrt(64) + exp(2)' is correct. Expected: 15.38905609893065, Actual: 15.38905609893065
+ Expression 'cos(pi/6) - 2^2' is correct. Expected: -3.0000417560069996, Actual: -3.0000417560069996
+ Expression '6! / 3!' is correct. Expected: 120, Actual: 120
+ Expression 'exp(3) + sqrt(36)' is correct. Expected: 26.085536923187668, Actual: 26.085536923187668
+ Expression '7! - 4!' is correct. Expected: 5016, Actual: 5016
+ Expression 'cos(pi) * 3^2' is correct. Expected: 8.986474348774774, Actual: 8.986474348774774
+ Expression 'sqrt(49) + exp(1)' is correct. Expected: 9.718281828459045, Actual: 9.718281828459045
+ Expression '8! / 6!' is correct. Expected: 56, Actual: 56
+ Expression '5! * sin(pi/3)' is correct. Expected: 2.19312331542573, Actual: 2.19312331542573
+ Expression '2^6 - sqrt(121)' is correct. Expected: 53, Actual: 53
+ Expression 'cos(pi/2) + 3!' is correct. Expected: 6.999624216859481, Actual: 6.999624216859481
+ Expression '9! / 7!' is correct. Expected: 72, Actual: 72
+ Expression 'exp(2) * sqrt(25)' is correct. Expected: 36.945280494653254, Actual: 36.945280494653254
+ Expression '4! + cos(pi/4)' is correct. Expected: 24.99990604980155, Actual: 24.99990604980155
+ Expression '3! + 4!' is correct. Expected: 30, Actual: 30
+ Expression 'sqrt(49) * exp(1)' is correct. Expected: 19.027972799213316, Actual: 19.027972799213316
+ Expression 'sin(pi/4) + 5^2' is correct. Expected: 25.01370735460471, Actual: 25.01370735460471
+ Expression '7! - 6!' is correct. Expected: 4320, Actual: 4320
+ Expression '2^5 / cos(pi/6)' is correct. Expected: 32.00133624802037, Actual: 32.00133624802037
+ Expression 'sqrt(36) + exp(3)' is correct. Expected: 26.085536923187668, Actual: 26.085536923187668
+ Expression 'cos(pi/3) - 2^4' is correct. Expected: -15.00016702054087, Actual: -15.00016702054087
+ Expression '4! + sqrt(64)' is correct. Expected: 32, Actual: 32
+ Expression 'exp(2) / 3!' is correct. Expected: 1.231509349821775, Actual: 1.231509349821775
+ Expression 'sin(pi/2) * sqrt(16)' is correct. Expected: 0.10964853436817716, Actual: 0.10964853436817716
+ Expression '5! / (2! * 3!)' is correct. Expected: 10, Actual: 10
+ Expression '2^3 + cos(pi/2)' is correct. Expected: 8.999624216859482, Actual: 8.999624216859482
+ Expression 'sqrt(81) - exp(1)' is correct. Expected: 6.281718171540955, Actual: 6.281718171540955
+ Expression '3! * 2^2' is correct. Expected: 24, Actual: 24
+ Expression 'cos(pi/4) + sqrt(100)' is correct. Expected: 10.99990604980155, Actual: 10.99990604980155
+ Expression 'exp(1) + 4!' is correct. Expected: 26.718281828459045, Actual: 26.718281828459045
+ Expression '6! / (3! * 3!)' is correct. Expected: 20, Actual: 20
+ Expression 'sqrt(121) * sin(pi/6)' is correct. Expected: 0.10052234936893649, Actual: 0.10052234936893649
+ Expression 'cos(pi/6) + 5!' is correct. Expected: 120.999958243993, Actual: 120.999958243993
+ Expression '2^6 - exp(2)' is correct. Expected: 56.61094390106935, Actual: 56.61094390106935
+ Expression '7! + sqrt(49)' is correct. Expected: 5047, Actual: 5047
+ Expression 'sqrt(25) * exp(2)' is correct. Expected: 36.945280494653254, Actual: 36.945280494653254
+ Expression '3^3 + cos(pi)' is correct. Expected: 27.998497149863862, Actual: 27.998497149863862
+ Expression '4! - sin(pi/3)' is correct. Expected: 23.98172397237145, Actual: 23.98172397237145
+ Expression 'exp(3) + 2^3' is correct. Expected: 28.085536923187668, Actual: 28.085536923187668
+ Expression 'cos(pi/2) * sqrt(64)' is correct. Expected: 7.996993734875853, Actual: 7.996993734875853
+ Expression 'sin(pi/4) / exp(1)' is correct. Expected: 0.005042653951918582, Actual: 0.005042653951918582
+ Expression 'sqrt(16) + 3!' is correct. Expected: 10, Actual: 10
+ Expression '2^5 * cos(pi/4)' is correct. Expected: 31.996993593649616, Actual: 31.996993593649616
+ Expression '4! / sqrt(49)' is correct. Expected: 3.4285714285714284, Actual: 3.4285714285714284
+ Expression 'asin(0.5) + acos(0.8)' is correct. Expected: 1.5655599960836912, Actual: 1.5655599960836912
+ Expression 'atan(1) + atan(2)' is correct. Expected: 0.052343938508789226, Actual: 0.052343938508789226
+ Expression 'log(10) + lg(8)' is correct. Expected: 5.302585092994046, Actual: 5.302585092994046
+ Expression 'asin(0.7) + acos(0.6)' is correct. Expected: 1.5725417685920733, Actual: 1.5725417685920733
+ Expression 'atan(0.5) + atan(3)' is correct. Expected: 0.061038531668438964, Actual: 0.061038531668438964
+ Expression 'log(8) + lg(16)' is correct. Expected: 6.079441541679836, Actual: 6.079441541679836
+ Expression 'asin(0.3) + acos(0.4)' is correct. Expected: 1.5690509647563957, Actual: 1.5690509647563957
+ Expression 'atan(2) + atan(1)' is correct. Expected: 0.052343938508789226, Actual: 0.052343938508789226
+ Expression 'log(2) + lg (4)' is correct. Expected: 2.6931471805599454, Actual: 2.6931471805599454
+ Expression 'asin(0.6) + acos(0.7)' is correct. Expected: 1.5690508849977198, Actual: 1.5690508849977198
+ Expression 'atan(3) + atan(0.5)' is correct. Expected: 0.061038531668438964, Actual: 0.061038531668438964
+ Expression 'log(16) + lg(32)' is correct. Expected: 7.772588722239782, Actual: 7.772588722239782
+ Expression 'asin(0.4) + acos(0.3)' is correct. Expected: 1.5725416888333974, Actual: 1.5725416888333974
+ Expression 'atan(1) + atan(4)' is correct. Expected: 0.08715160095107907, Actual: 0.08715160095107907
+ Expression 'log(4) + lg(2)' is correct. Expected: 2.386294361119891, Actual: 2.386294361119891
+ Expression 'asin(0.8) + acos(0.5)' is correct. Expected: 1.5760326575061019, Actual: 1.5760326575061019
+ Expression 'atan(0.25) + atan(5)' is correct. Expected: 0.0914092407282499, Actual: 0.0914092407282499
+ Expression 'log(32) + lg(64)' is correct. Expected: 9.465735902799727, Actual: 9.465735902799727
+ Expression 'sqrt(10) * exp(2) - 3^2' is correct. Expected: 14.366247031379313, Actual: 14.366247031379313
+ Expression 'asin(0.2) + atan(1) * 2' is correct. Expected: 0.03839370689572842, Actual: 0.03839370689572842
+ Expression 'log(20) + lg(5) * sqrt(4)' is correct. Expected: 7.639588463328716, Actual: 7.639588463328716
+ Expression 'sqrt(15) * exp(3) / 2^2' is correct. Expected: 19.447737500785, Actual: 19.447737500785
+ Expression 'acos(0.4) + atan(2) / 3!' is correct. Expected: 1.569630356051742, Actual: 1.569630356051742
+ Expression 'log(25) + lg(10) / sqrt(5)' is correct. Expected: 4.7044872321751035, Actual: 4.7044872321751035
+ Expression 'sqrt(12) * exp(4) - 4^2' is correct. Expected: 173.1335397133484, Actual: 173.1335397133484
+ Expression 'asin(0.3) + atan(3) * 3' is correct. Expected: 0.16217233244802867, Actual: 0.16217233244802867
+ Expression 'log(30) + lg(15) / sqrt(10)' is correct. Expected: 4.636664666783631, Actual: 4.636664666783631
+ Expression 'sqrt(18) * exp(5) / 2^3' is correct. Expected: 78.70796341406242, Actual: 78.70796341406242
+ Expression 'acos(0.5) + atan(4) / 4!' is correct. Expected: 1.5649737397815935, Actual: 1.5649737397815935
+ Expression 'log(35) + lg(20) / sqrt(15)' is correct. Expected: 4.671265097156394, Actual: 4.671265097156394
+ Expression 'sqrt(20) * exp(6) - 5^2' is correct. Expected: 1779.1884126609611, Actual: 1779.1884126609611
+ Expression 'asin(0.4) + atan(5) * 5' is correct. Expected: 0.4422111001616382, Actual: 0.4422111001616382
+ Expression 'log(40) + lg(25) / sqrt(20)' is correct. Expected: 4.727277265920881, Actual: 4.727277265920881
+ Expression 'sqrt(22) * exp(7) / 2^4' is correct. Expected: 321.4790905648616, Actual: 321.4790905648616
+ Expression 'acos(0.6) + atan(6) / 5!' is correct. Expected: 1.561193655382539, Actual: 1.561193655382539
+ Expression 'log(45) + lg(30) / sqrt(25)' is correct. Expected: 4.7880406088920235, Actual: 4.7880406088920235
+ Expression 'sqrt(24) * exp(8) - 6^2' is correct. Expected: 14567.652025852605, Actual: 14567.652025852605
+ Expression 'asin(0.5) + atan(7) * 7' is correct. Expected: 0.8597207621683767, Actual: 0.8597207621683767
+ Expression 'log(50) + lg(35) / sqrt(30)' is correct. Expected: 4.84849767616445, Actual: 4.84849767616445
+ Expression 'sqrt(26) * exp(9) / 2^5' is correct. Expected: 1291.180720843342, Actual: 1291.180720843342
+ Expression 'acos(0.7) + atan(8) / 6!' is correct. Expected: 1.5587713978653739, Actual: 1.5587713978653739
+ Expression 'log(55) + lg(40) / sqrt(35)' is correct. Expected: 4.9069032197831275, Actual: 4.9069032197831275
+ Expression 'sqrt(28) * exp(10) - 7^2' is correct. Expected: 116504.10150945847, Actual: 116504.10150945847
+ Expression 'asin(0.6) + atan(9) * 9' is correct. Expected: 1.4127306666440569, Actual: 1.4127306666440569
+ Expression 'log(60) + lg(45) / sqrt(40)' is correct. Expected: 4.962682780194594, Actual: 4.962682780194594
+ Expression 'sqrt(30) * exp(11) / 2^6' is correct. Expected: 5124.127816980454, Actual: 5124.127816980454
+ Expression 'acos(0.8) + atan(10) / 7!' is correct. Expected: 1.5568675232711693, Actual: 1.5568675232711693
+ Expression 'log(65) + lg(50) / sqrt(45)' is correct. Expected: 5.015723676266919, Actual: 5.015723676266919
+ Expression 'asin(5)' is correct. Expected: 0.08737760592421796, Actual: 0.08737760592421796
! Total correct expressions: 109/109
```
</details>

## Acknowledgments 🙏

- Thanks to the contributors of the Stack Overflow community for their valuable insights and solutions.
- Also thanks to ChatGPT for the error handling and documentation 😄

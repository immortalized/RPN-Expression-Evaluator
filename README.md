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

- The algorithm passed the tests including edge cases and hard expressions.

### Results

<details>
  <summary>
    Results (301 out of 301 correct)
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
+ Expression 'log(30) * lg(6) + 2^3' is correct. Expected: 16.791967689147654, Actual: 16.791967689147654
+ Expression 'asin(0.5) + acos(0.7) - sqrt(49)' is correct. Expected: -5.432694524894675, Actual: -5.432694524894675
+ Expression 'sqrt(20) + exp(1) * log(5)' is correct. Expected: 8.847041786402254, Actual: 8.847041786402254
+ Expression 'cos(pi/5) * sqrt(25) + 3^3' is correct. Expected: 31.99969935767021, Actual: 31.99969935767021
+ Expression 'atan(3) / sin(pi/4) + lg(7)' is correct. Expected: 6.623708144904803, Actual: 6.623708144904803
+ Expression 'sqrt(18) + exp(2) / log(10)' is correct. Expected: 7.4516669773584345, Actual: 7.4516669773584345
+ Expression 'acos(0.6) * atan(0.5) - sqrt(16)' is correct. Expected: -3.9863839486393857, Actual: -3.9863839486393857
+ Expression 'log(40) + lg(8) * sqrt(9)' is correct. Expected: 12.688879454113936, Actual: 12.688879454113936
+ Expression 'sqrt(12) * exp(3) - 5!' is correct. Expected: -50.4216591034766, Actual: -50.4216591034766
+ Expression 'asin(0.9) + acos(0.1) + 2^6' is correct. Expected: 65.58475960596058, Actual: 65.58475960596058
+ Expression 'atan(4) * log(15) + lg(3)' is correct. Expected: 1.773713817193364, Actual: 1.773713817193364
+ Expression 'sqrt(22) + exp(1) / log(8)' is correct. Expected: 5.997632997708912, Actual: 5.997632997708912
+ Expression 'cos(pi/6) * sqrt(30) + 4!' is correct. Expected: 29.476996867982212, Actual: 29.476996867982212
+ Expression 'asin(0.4) + acos(0.2) * sqrt(5)' is correct. Expected: 3.511583373687525, Actual: 3.511583373687525
+ Expression 'log(50) + lg(10) - 3!' is correct. Expected: 1.2339511003155081, Actual: 1.2339511003155081
+ Expression 'sqrt(25) * exp(2) + 2^4' is correct. Expected: 52.945280494653254, Actual: 52.945280494653254
+ Expression 'atan(1) / sin(pi/3) + lg(9)' is correct. Expected: 4.12481087741932, Actual: 4.12481087741932
+ Expression 'sqrt(14) + exp(1) * log(4)' is correct. Expected: 7.509996157501382, Actual: 7.509996157501382
+ Expression 'acos(0.8) + atan(0.3) / 2!' is correct. Expected: 1.5594512090116932, Actual: 1.5594512090116932
+ Expression 'log(60) * lg(12) + 3^2' is correct. Expected: 23.678071720597806, Actual: 23.678071720597806
+ Expression 'sqrt(21) + exp(3) - 4!' is correct. Expected: 0.6681126181435069, Actual: 0.6681126181435069
+ Expression 'asin(0.2) + acos(0.5) + 2^5' is correct. Expected: 33.56556023536191, Actual: 33.56556023536191
+ Expression 'atan(2) * log(18) + lg(2)' is correct. Expected: 1.1008520591395194, Actual: 1.1008520591395194
+ Expression 'sqrt(19) + exp(2) / log(5)' is correct. Expected: 8.94997763122705, Actual: 8.94997763122705
+ Expression 'cos(pi/4) * sqrt(28) + 5!' is correct. Expected: 125.29100548440773, Actual: 125.29100548440773
+ Expression 'asin(0.3) + acos(0.1) * sqrt(7)' is correct. Expected: 4.156554743212818, Actual: 4.156554743212818
+ Expression 'log(70) + lg(15) - 4!' is correct. Expected: -15.844614162342122, Actual: -15.844614162342122
+ Expression 'sqrt(24) * exp(2) + 3^4' is correct. Expected: 117.19883424636022, Actual: 117.19883424636022
+ Expression 'atan(0.5) / sin(pi/6) + lg(5)' is correct. Expected: 3.2768468050966875, Actual: 3.2768468050966875
+ Expression 'sqrt(17) + exp(1) * log(6)' is correct. Expected: 8.993612831789706, Actual: 8.993612831789706
+ Expression 'acos(0.7) + atan(0.2) / 3!' is correct. Expected: 1.5591604921339641, Actual: 1.5591604921339641
+ Expression 'log(80) * lg(18) + 2^5' is correct. Expected: 50.272722420912736, Actual: 50.272722420912736
+ Expression 'sqrt(23) + exp(3) - 5!' is correct. Expected: -95.11863155349961, Actual: -95.11863155349961
+ Expression 'asin(0.1) + acos(0.6) + 3^3' is correct. Expected: 28.562069490014807, Actual: 28.562069490014807
+ Expression 'atan(1) * log(20) + lg(4)' is correct. Expected: 2.0522800836381903, Actual: 2.0522800836381903
+ Expression 'sqrt(27) + exp(2) / log(7)' is correct. Expected: 8.99337610362419, Actual: 8.99337610362419
+ Expression 'cos(pi/3) * sqrt(35) + 4!' is correct. Expected: 29.915091676254413, Actual: 29.915091676254413
+ Expression 'asin(0.4) + acos(0.3) * sqrt(9)' is correct. Expected: 4.703662319061442, Actual: 4.703662319061442
+ Expression 'log(90) + lg(20) - 3!' is correct. Expected: 2.8217377652176268, Actual: 2.8217377652176268
+ Expression 'sqrt(26) * exp(2) + 2^6' is correct. Expected: 101.67694123547916, Actual: 101.67694123547916
+ Expression 'atan(0.2) / sin(pi/4) + lg(8)' is correct. Expected: 3.254654849693247, Actual: 3.254654849693247
+ Expression 'sqrt(16) + exp(1) * log(8)' is correct. Expected: 9.652508156091159, Actual: 9.652508156091159
+ Expression 'acos(0.2) + atan(0.1) / 2!' is correct. Expected: 1.5681783249420023, Actual: 1.5681783249420023
+ Expression 'log(100) * lg(25) + 3^3' is correct. Expected: 48.38574807316682, Actual: 48.38574807316682
+ Expression 'sqrt(28) + exp(3) - 2!' is correct. Expected: 23.377039545316848, Actual: 23.377039545316848
+ Expression 'asin(0.7) + acos(0.8) + 2^7' is correct. Expected: 129.56905084777327, Actual: 129.56905084777327
+ Expression 'atan(0.8) * log(30) + lg(9)' is correct. Expected: 3.2174115899405917, Actual: 3.2174115899405917
+ Expression 'sqrt(31) + exp(1) / log(2)' is correct. Expected: 9.48941607648647, Actual: 9.48941607648647
+ Expression 'cos(pi/4) * sqrt(45) + 5!' is correct. Expected: 126.70757369540867, Actual: 126.70757369540867
+ Expression 'asin(0.2) + acos(0.1) * sqrt(11)' is correct. Expected: 5.2074440984366035, Actual: 5.2074440984366035
+ Expression 'log(110) + lg(12) - 4!' is correct. Expected: -15.714557133486426, Actual: -15.714557133486426
+ Expression 'sqrt(34) * exp(2) + 3^5' is correct. Expected: 286.0852306611779, Actual: 286.0852306611779
+ Expression 'atan(0.5) / sin(pi/2) + lg(7)' is correct. Expected: 3.1256966051941117, Actual: 3.1256966051941117
+ Expression 'sqrt(35) + exp(2) * log(9)' is correct. Expected: 22.15149544698613, Actual: 22.15149544698613
+ Expression 'log(120) * lg(18) + 2^7' is correct. Expected: 147.9634815124255, Actual: 147.9634815124255
+ Expression 'sqrt(40) + exp(3) - 5!' is correct. Expected: -93.58990775647557, Actual: -93.58990775647557
+ Expression 'asin(0.6) + acos(0.4) + 3^3' is correct. Expected: 28.574287119993702, Actual: 28.574287119993702
+ Expression 'atan(0.6) * log(35) + lg(3)' is correct. Expected: 1.622192657682862, Actual: 1.622192657682862
+ Expression 'sqrt(36) + exp(1) / log(10)' is correct. Expected: 7.180534798357645, Actual: 7.180534798357645
+ Expression 'cos(pi/6) * sqrt(50) + 4!' is correct. Expected: 31.070772552308426, Actual: 31.070772552308426
+ Expression 'asin(0.5) + acos(0.2) * sqrt(13)' is correct. Expected: 5.659727682814949, Actual: 5.659727682814949
+ Expression 'log(130) + lg(15) - 3!' is correct. Expected: 2.774425046064101, Actual: 2.774425046064101
+ Expression 'sqrt(42) * exp(2) + 2^8' is correct. Expected: 303.88655658315867, Actual: 303.88655658315867
+ Expression 'atan(0.1) / sin(pi/3) + lg(10)' is correct. Expected: 3.4174262805586837, Actual: 3.4174262805586837
+ Expression 'sqrt(44) + exp(1) * log(12)' is correct. Expected: 13.387926172246566, Actual: 13.387926172246566
+ Expression 'acos(0.9) + atan(0.4) / 2!' is correct. Expected: 1.5585783192866092, Actual: 1.5585783192866092
+ Expression 'log(140) * lg(20) + 3^2' is correct. Expected: 30.3574232211624, Actual: 30.3574232211624
+ Expression 'sqrt(49) + exp(3) - 4!' is correct. Expected: 3.085536923187668, Actual: 3.085536923187668
+ Expression 'asin(0.9) + acos(0.5) + 2^9' is correct. Expected: 513.5777781790729, Actual: 513.5777781790729
+ Expression 'atan(1) * log(40) + lg(2)' is correct. Expected: 1.0643765559742373, Actual: 1.0643765559742373
+ Expression 'sqrt(52) + exp(2) / log(15)' is correct. Expected: 9.9396546641507, Actual: 9.9396546641507
+ Expression 'cos(pi/5) * sqrt(55) + 5!' is correct. Expected: 127.4157525624574, Actual: 127.4157525624574
+ Expression 'asin(0.8) + acos(0.4) * sqrt(14)' is correct. Expected: 5.865222858459561, Actual: 5.865222858459561
+ Expression 'log(150) + lg(25) - 4!' is correct. Expected: -14.34550851612902, Actual: -14.34550851612902
+ Expression 'sqrt(54) * exp(2) + 3^6' is correct. Expected: 783.2982513695404, Actual: 783.2982513695404
+ Expression 'atan(0.4) / sin(pi/4) + lg(5)' is correct. Expected: 2.8312315886912303, Actual: 2.8312315886912303
+ Expression 'sqrt(55) + exp(1) * log(18)' is correct. Expected: 15.273043514076033, Actual: 15.273043514076033
+ Expression 'acos(0.6) + atan(0.3) / 3!' is correct. Expected: 1.5611968165279781, Actual: 1.5611968165279781
+ Expression 'log(160) * lg(30) + 2^8' is correct. Expected: 280.9033226650495, Actual: 280.9033226650495
+ Expression 'sqrt(57) + exp(3) - 5!' is correct. Expected: -92.36462864154159, Actual: -92.36462864154159
+ Expression 'asin(0.4) + acos(0.6) + 3^4' is correct. Expected: 82.56730553359608, Actual: 82.56730553359608
+ Expression 'atan(0.3) * log(45) + lg(4)' is correct. Expected: 2.0199314560448673, Actual: 2.0199314560448673
+ Expression 'sqrt(60) + exp(2) / log(20)' is correct. Expected: 10.21249421363576, Actual: 10.21249421363576
+ Expression 'cos(pi/3) * sqrt(65) + 4!' is correct. Expected: 32.06091118564879, Actual: 32.06091118564879
+ Expression 'asin(0.5) + acos(0.3) * sqrt(15)' is correct. Expected: 6.072115784945631, Actual: 6.072115784945631
+ Expression 'log(170) + lg(35) - 3!' is correct. Expected: 4.265081453995229, Actual: 4.265081453995229
+ Expression 'sqrt(62) * exp(2) + 2^9' is correct. Expected: 570.1814859044949, Actual: 570.1814859044949
+ Expression 'atan(0.7) / sin(pi/6) + lg(11)' is correct. Expected: 4.796285237403401, Actual: 4.796285237403401
+ Expression 'sqrt(64) + exp(1) * log(22)' is correct. Expected: 16.402324531959376, Actual: 16.402324531959376
+ Expression 'log(180) * lg(40) + 3^2' is correct. Expected: 36.63654296029041, Actual: 36.63654296029041
+ Expression 'sqrt(66) + exp(3) - 4!' is correct. Expected: 4.209575327823629, Actual: 4.209575327823629
+ Expression 'asin(0.2) + acos(0.7) + 2^10' is correct. Expected: 1025.5620693836722, Actual: 1025.5620693836722
+ Expression 'atan(0.9) * log(50) + lg(3)' is correct. Expected: 1.646407361089063, Actual: 1.646407361089063
+ Expression 'sqrt(68) + exp(2) / log(25)' is correct. Expected: 10.54175059507851, Actual: 10.54175059507851
+ Expression 'cos(pi/4) * sqrt(75) + 5!' is correct. Expected: 128.65944040525892, Actual: 128.65944040525892
+ Expression 'asin(0.3) + acos(0.8) * sqrt(17)' is correct. Expected: 6.4242238977890835, Actual: 6.4242238977890835
+ Expression 'log(190) + lg(50) - 4!' is correct. Expected: -13.10911973806479, Actual: -13.10911973806479
+ Expression 'sqrt(70) * exp(2) + 3^7' is correct. Expected: 2248.821278717931, Actual: 2248.821278717931
+ Expression 'atan(0.6) / sin(pi/4) + lg(7)' is correct. Expected: 3.571294649714122, Actual: 3.571294649714122
+ Expression 'sqrt(72) + exp(1) * log(30)' is correct. Expected: 17.73069441181329, Actual: 17.73069441181329
+ Expression 'acos(0.2) + atan(0.4) / 3!' is correct. Expected: 1.5684691951339307, Actual: 1.5684691951339307
+ Expression 'log(200) * lg(60) + 2^9' is correct. Expected: 543.2965810250118, Actual: 543.2965810250118
+ Expression 'sqrt(74) + exp(3) - 5!' is correct. Expected: -91.31213780976971, Actual: -91.31213780976971
+ Expression 'asin(0.6) + acos(0.2) + 3^4' is correct. Expected: 82.57777782812028, Actual: 82.57777782812028
+ Expression 'atan(0.5) * log(55) + lg(6)' is correct. Expected: 2.6199321921944527, Actual: 2.6199321921944527
+ Expression 'sqrt(76) + exp(2) / log(35)' is correct. Expected: 10.796091199335905, Actual: 10.796091199335905
+ Expression 'cos(pi/6) * sqrt(80) + 4!' is correct. Expected: 32.94389843291868, Actual: 32.94389843291868
+ Expression 'asin(0.7) + acos(0.3) * sqrt(18)' is correct. Expected: 6.654327499757398, Actual: 6.654327499757398
+ Expression 'log(210) + lg(70) - 3!' is correct. Expected: 5.476390547662435, Actual: 5.476390547662435
+ Expression 'sqrt(78) * exp(2) + 2^10' is correct. Expected: 1089.258376493637, Actual: 1089.258376493637
+ Expression 'atan(0.2) / sin(pi/5) + lg(8)' is correct. Expected: 3.3183149733126798, Actual: 3.3183149733126798
+ Expression 'sqrt(80) + exp(1) * log(40)' is correct. Expected: 18.971685897492996, Actual: 18.971685897492996
+ Expression 'acos(0.5) + atan(0.3) / 2!' is correct. Expected: 1.5646875397228985, Actual: 1.5646875397228985
+ Expression 'log(220) * lg(80) + 3^2' is correct. Expected: 43.098125518643386, Actual: 43.098125518643386
+ Expression 'sqrt(82) + exp(3) - 4!' is correct. Expected: 5.140922061325085, Actual: 5.140922061325085
+ Expression 'asin(0.4) + acos(0.9) + 2^11' is correct. Expected: 2049.5620690912106, Actual: 2049.5620690912106
+ Expression 'atan(0.9) * log(60) + lg(2)' is correct. Expected: 1.0643085251734872, Actual: 1.0643085251734872
+ Expression 'sqrt(84) + exp(2) / log(45)' is correct. Expected: 11.106236558031346, Actual: 11.106236558031346
+ Expression 'cos(pi/5) * sqrt(90) + 5!' is correct. Expected: 129.4862625517912, Actual: 129.4862625517912
+ Expression 'asin(0.8) + acos(0.4) * sqrt(19)' is correct. Expected: 6.830474434590991, Actual: 6.830474434590991
+ Expression 'log(230) + lg(90) - 4!' is correct. Expected: -12.07006759474713, Actual: -12.07006759474713
+ Expression 'sqrt(88) * exp(2) + 3^8' is correct. Expected: 6630.315490353288, Actual: 6630.315490353288
+ Expression 'atan(0.4) / sin(pi/3) + lg(9)' is correct. Expected: 3.5519119262202756, Actual: 3.5519119262202756
+ Expression 'sqrt(90) + exp(1) * log(50)' is correct. Expected: 20.120814028674207, Actual: 20.120814028674207
+ Expression 'acos(0.6) + atan(0.2) / 3!' is correct. Expected: 1.5609059339311409, Actual: 1.5609059339311409
+ Expression 'log(240) * lg(100) + 2^10' is correct. Expected: 1060.412576834766, Actual: 1060.412576834766
+ Expression 'sqrt(92) + exp(3) - 5!' is correct. Expected: -90.3228000301869, Actual: -90.3228000301869
+ Expression 'asin(0.5) + acos(0.3) + 3^5' is correct. Expected: 244.5742870721398, Actual: 244.5742870721398
+ Expression 'atan(0.3) * log(70) + lg(3)' is correct. Expected: 1.6072073665061561, Actual: 1.6072073665061561
+ Expression 'sqrt(95) + exp(2) / log(60)' is correct. Expected: 11.551492505073332, Actual: 11.551492505073332
+ Expression 'cos(pi/4) * sqrt(100) + 4!' is correct. Expected: 33.9990604980155, Actual: 33.9990604980155
+ Expression 'asin(0.2) + acos(0.8) * sqrt(21)' is correct. Expected: 7.1377968279989235, Actual: 7.1377968279989235
+ Expression 'log(250) + lg(120) - 3!' is correct. Expected: 6.428351513470766, Actual: 6.428351513470766
+ Expression 'sqrt(98) * exp(2) + 2^11' is correct. Expected: 2121.1479234377034, Actual: 2121.1479234377034
+ Expression 'atan(0.1) / sin(pi/4) + lg(10)' is correct. Expected: 3.4492559075935327, Actual: 3.4492559075935327
+ Expression 'sqrt(100) + exp(1) * log(70)' is correct. Expected: 21.548607414757484, Actual: 21.548607414757484
+ Expression 'acos(0.8) + atan(0.6) / 2!' is correct. Expected: 1.56206903542971, Actual: 1.56206903542971
+ Expression 'log(260) * lg(150) + 3^2' is correct. Expected: 49.197159306182165, Actual: 49.197159306182165
+ Expression 'sqrt(104) + exp(3) - 4!' is correct. Expected: 6.283575950373237, Actual: 6.283575950373237
+ Expression 'asin(0.3) + acos(0.2) + 2^12' is correct. Expected: 4097.572541672883, Actual: 4097.572541672883
+ Expression 'atan(0.5) * log(80) + lg(4)' is correct. Expected: 2.038239425662687, Actual: 2.038239425662687
+ Expression 'sqrt(108) + exp(2) / log(80)' is correct. Expected: 12.078523737937306, Actual: 12.078523737937306
+ Expression 'cos(pi/6) * sqrt(110) + 5!' is correct. Expected: 130.48765054100545, Actual: 130.48765054100545
+ Expression 'asin(0.7) + acos(0.1) * sqrt(22)' is correct. Expected: 7.371719131401095, Actual: 7.371719131401095
+ Expression 'log(270) + lg(200) - 4!' is correct. Expected: -10.7577218512269, Actual: -10.7577218512269
+ Expression 'sqrt(110) * exp(2) + 3^9' is correct. Expected: 19760.49707416184, Actual: 19760.49707416184
+ Expression 'atan(0.3) / sin(pi/5) + lg(11)' is correct. Expected: 3.936901654546921, Actual: 3.936901654546921
+ Expression 'sqrt(115) + exp(1) * log(90)' is correct. Expected: 22.955556153146652, Actual: 22.955556153146652
+ Expression 'acos(0.3) + atan(0.2) / 3!' is correct. Expected: 1.5661420891684479, Actual: 1.5661420891684479
+ Expression 'log(280) * lg(250) + 2^10' is correct. Expected: 1068.885518468303, Actual: 1068.885518468303
+ Expression 'sqrt(118) + exp(3) - 5!' is correct. Expected: -89.05168258561211, Actual: -89.05168258561211
+ Expression 'asin(0.4) + acos(0.5) + 3^4' is correct. Expected: 82.56905094348849, Actual: 82.56905094348849
+ Expression 'atan(0.7) * log(90) + lg(5)' is correct. Expected: 2.3769009059914015, Actual: 2.3769009059914015
+ Expression 'sqrt(120) + exp(2) / log(100)' is correct. Expected: 12.558964295222896, Actual: 12.558964295222896
+ Expression 'cos(pi/3) * sqrt(125) + 4!' is correct. Expected: 35.17847254108383, Actual: 35.17847254108383
+ Expression 'asin(0.1) + acos(0.2) * sqrt(23)' is correct. Expected: 7.518279226797606, Actual: 7.518279226797606
+ Expression 'log(290) + lg(300) - 3!' is correct. Expected: 7.898699613476401, Actual: 7.898699613476401
+ Expression 'sqrt(126) * exp(2) + 2^12' is correct. Expected: 4178.9419490015525, Actual: 4178.9419490015525
+ Expression 'atan(0.6) / sin(pi/4) + lg(6)' is correct. Expected: 3.348902228377674, Actual: 3.348902228377674
+ Expression 'sqrt(130) + exp(1) * log(110)' is correct. Expected: 24.178984614353432, Actual: 24.178984614353432
+ Expression 'acos(0.5) + atan(0.7) / 2!' is correct. Expected: 1.5681779182473248, Actual: 1.5681779182473248
+ Expression 'log(300) * lg(350) + 3^3' is correct. Expected: 75.20386982928898, Actual: 75.20386982928898
+ Expression 'sqrt(132) + exp(3) - 4!' is correct. Expected: 7.574662216263725, Actual: 7.574662216263725
+ Expression 'asin(0.5) + acos(0.9) + 2^13' is correct. Expected: 8193.563814474517, Actual: 8193.563814474517
+ Expression 'atan(0.8) * log(100) + lg(2)' is correct. Expected: 1.0642961278182839, Actual: 1.0642961278182839
+ Expression 'sqrt(134) + exp(2) / log(120)' is correct. Expected: 13.119245538443938, Actual: 13.119245538443938
+ Expression 'cos(pi/4) * sqrt(140) + 5!' is correct. Expected: 131.8310479324599, Actual: 131.8310479324599
+ Expression 'asin(0.3) + acos(0.1) * sqrt(24)' is correct. Expected: 7.691984656110006, Actual: 7.691984656110006
+ Expression 'log(310) + lg(400) - 4!' is correct. Expected: -9.619571512746083, Actual: -9.619571512746083
+ Expression 'sqrt(136) * exp(2) + 3^10' is correct. Expected: 59135.170461322356, Actual: 59135.170461322356
+ Expression 'atan(0.9) / sin(pi/6) + lg(7)' is correct. Expected: 4.526110879568071, Actual: 4.526110879568071
+ Expression 'sqrt(140) + exp(1) * log(130)' is correct. Expected: 25.063490012271025, Actual: 25.063490012271025
+ Expression 'acos(0.7) + atan(0.6) / 3!' is correct. Expected: 1.560323983536807, Actual: 1.560323983536807
+ Expression 'log(320) * lg(450) + 2^11' is correct. Expected: 2098.8407190976295, Actual: 2098.8407190976295
+ Expression 'sqrt(142) + exp(3) - 5!' is correct. Expected: -87.99808778899936, Actual: -87.99808778899936
+ Expression 'asin(0.6) + acos(0.4) + 3^5' is correct. Expected: 244.5742871199937, Actual: 244.5742871199937
+ Expression 'atan(0.2) * log(110) + lg(3)' is correct. Expected: 1.601370205842087, Actual: 1.601370205842087
+ Expression 'sqrt(145) + exp(2) / log(140)' is correct. Expected: 13.536857786248138, Actual: 13.536857786248138
+ Expression 'cos(pi/5) * sqrt(150) + 4!' is correct. Expected: 36.24671229361282, Actual: 36.24671229361282
+ Expression 'asin(0.9) + acos(0.2) * sqrt(25)' is correct. Expected: 7.852236915314279, Actual: 7.852236915314279
+ Expression 'log(330) + lg(500) - 3!' is correct. Expected: 8.764876939122612, Actual: 8.764876939122612
+ Expression 'sqrt(148) * exp(2) + 2^12' is correct. Expected: 4185.891747145693, Actual: 4185.891747145693
+ Expression 'atan(0.4) / sin(pi/3) + lg(8)' is correct. Expected: 3.3819869247779635, Actual: 3.3819869247779635
+ Expression 'sqrt(150) + exp(1) * log(150)' is correct. Expected: 25.867767582893286, Actual: 25.867767582893286
+ Expression 'acos(0.9) + atan(0.8) / 2!' is correct. Expected: 1.562068580870923, Actual: 1.562068580870923
+ Expression 'log(340) * lg(600) + 3^4' is correct. Expected: 134.79428226168514, Actual: 134.79428226168514
+ Expression 'sqrt(154) + exp(3) - 4!' is correct. Expected: 8.495210569178525, Actual: 8.495210569178525
+ Expression 'asin(0.1) + acos(0.7) + 2^14' is correct. Expected: 16385.560324048216, Actual: 16385.560324048216
+ Expression 'atan(0.5) * log(120) + lg(4)' is correct. Expected: 2.0417776864157435, Actual: 2.0417776864157435
+ Expression 'sqrt(156) + exp(2) / log(160)' is correct. Expected: 13.945917777594016, Actual: 13.945917777594016
+ Expression 'cos(pi/6) * sqrt(165) + 5!' is correct. Expected: 132.84469621304368, Actual: 132.84469621304368
+ Expression 'asin(0.2) + acos(0.3) * sqrt(26)' is correct. Expected: 7.986313262065665, Actual: 7.986313262065665
+ Expression 'log(350) + lg(700) - 4!' is correct. Expected: -8.690855733684213, Actual: -8.690855733684213
+ Expression 'sqrt(160) * exp(2) + 3^11' is correct. Expected: 177240.46498812552, Actual: 177240.46498812552
+ Expression 'atan(0.8) / sin(pi/4) + lg(9)' is correct. Expected: 4.188482349832393, Actual: 4.188482349832393
+ Expression 'sqrt(162) + exp(1) * log(170)' is correct. Expected: 26.68846962741995, Actual: 26.68846962741995
+ Expression 'acos(0.2) + atan(0.5) / 3!' is correct. Expected: 1.568760065326442, Actual: 1.568760065326442
+ Expression 'log(360) * lg(800) + 2^11' is correct. Expected: 2104.7647407973586, Actual: 2104.7647407973586
+ Expression 'sqrt(164) + exp(3) - 5!' is correct. Expected: -87.10821460194663, Actual: -87.10821460194663
+ Expression 'asin(0.3) + acos(0.8) + 3^6' is correct. Expected: 730.5620692507388, Actual: 730.5620692507388
+ Expression 'atan(0.1) * log(130) + lg(5)' is correct. Expected: 2.330423536522641, Actual: 2.330423536522641
+ Expression 'sqrt(170) + exp(2) / log(180)' is correct. Expected: 14.461304385945574, Actual: 14.461304385945574
+ Expression 'cos(pi/4) * sqrt(175) + 4!' is correct. Expected: 37.22751371101934, Actual: 37.22751371101934
+ Expression 'asin(0.4) + acos(0.6) * sqrt(28)' is correct. Expected: 8.263440757078525, Actual: 8.263440757078525
+ Expression 'log(370) + lg(900) - 3!' is correct. Expected: 9.727284196855308, Actual: 9.727284196855308
+ Expression 'sqrt(178) * exp(2) + 2^13' is correct. Expected: 8290.582304222917, Actual: 8290.582304222917
+ Expression 'atan(0.3) / sin(pi/4) + lg(10)' is correct. Expected: 3.7039084301578518, Actual: 3.7039084301578518
+ Expression 'sqrt(180) + exp(1) * log(190)' is correct. Expected: 27.67929805383977, Actual: 27.67929805383977
+ Expression 'acos(0.4) + atan(0.6) / 2!' is correct. Expected: 1.5690507494473271, Actual: 1.5690507494473271
+ Expression 'log(380) * lg(1000) + 3^2' is correct. Expected: 68.19846531856278, Actual: 68.19846531856278
+ Expression 'sqrt(184) + exp(3) - 4!' is correct. Expected: 9.650196889438206, Actual: 9.650196889438206
+ Expression 'asin(0.6) + acos(0.5) + 2^14' is correct. Expected: 16385.57254173669, Actual: 16385.57254173669
+ Expression 'atan(0.4) * log(140) + lg(6)' is correct. Expected: 2.619461112547245, Actual: 2.619461112547245
+ Expression 'sqrt(190) + exp(2) / log(200)' is correct. Expected: 15.178653036382986, Actual: 15.178653036382986
+ Expression 'cos(pi/3) * sqrt(195) + 5!' is correct. Expected: 133.96190772884398, Actual: 133.96190772884398
+ Expression 'asin(0.7) + acos(0.7) * sqrt(30)' is correct. Expected: 8.54890482411184, Actual: 8.54890482411184
+ Expression 'log(390) + lg(1100) - 4!' is correct. Expected: -7.930565452464286, Actual: -7.930565452464286
+ Expression 'sqrt(194) * exp(2) + 3^12' is correct. Expected: 531543.9176423477, Actual: 531543.9176423477
@@ Total correct expressions: 301/301 @@
```
</details>

<details>
  <summary>
    Test expressions
  </summary>

```csharp
// A dictionary of the test expressions and their solutions
Dictionary<string, double> expressions = new Dictionary<string, double>
{
    {"5! + 3!", Factorial(5) + Factorial(3)},
    {"sqrt(16) + exp(1)", Math.Sqrt(16) + Math.Exp(1)},
    {"cos(pi/3) * 2^3", Cos(Math.PI / 3) * Math.Pow(2, 3)},
    {"sin(pi/6) + 3^2", Sin(Math.PI / 6) + Math.Pow(3, 2)},
    {"7! / 5!", Factorial(7) / Factorial(5)},
    {"2^3 + sqrt(81)", Math.Pow(2, 3) + Math.Sqrt(81)},
    {"exp(2) - 4!", Math.Exp(2) - Factorial(4)},
    {"sqrt(25) + cos(pi)", Math.Sqrt(25) + Cos(Math.PI)},
    {"10! / 8!", Factorial(10) / Factorial(8)},
    {"exp(1) * 5!", Math.Exp(1) * Factorial(5)},
    {"3! * sqrt(49)", Factorial(3) * Math.Sqrt(49)},
    {"cos(pi/4) + 2^5", Cos(Math.PI / 4) + Math.Pow(2, 5)},
    {"sqrt(100) - 2!", Math.Sqrt(100) - Factorial(2)},
    {"4! * cos(pi/3)", Factorial(4) * Cos(Math.PI / 3)},
    {"2^4 / exp(1)", Math.Pow(2, 4) / Math.Exp(1)},
    {"5! + sin(pi/2)", Factorial(5) + Sin(Math.PI / 2)},
    {"sqrt(64) + exp(2)", Math.Sqrt(64) + Math.Exp(2)},
    {"cos(pi/6) - 2^2", Cos(Math.PI / 6) - Math.Pow(2, 2)},
    {"6! / 3!", Factorial(6) / Factorial(3)},
    {"exp(3) + sqrt(36)", Math.Exp(3) + Math.Sqrt(36)},
    {"7! - 4!", Factorial(7) - Factorial(4)},
    {"cos(pi) * 3^2", Cos(Math.PI) * Math.Pow(3, 2)},
    {"sqrt(49) + exp(1)", Math.Sqrt(49) + Math.Exp(1)},
    {"8! / 6!", Factorial(8) / Factorial(6)},
    {"5! * sin(pi/3)", Factorial(5) * Sin(Math.PI / 3)},
    {"2^6 - sqrt(121)", Math.Pow(2, 6) - Math.Sqrt(121)},
    {"cos(pi/2) + 3!", Cos(Math.PI / 2) + Factorial(3)},
    {"9! / 7!", Factorial(9) / Factorial(7)},
    {"exp(2) * sqrt(25)", Math.Exp(2) * Math.Sqrt(25)},
    {"4! + cos(pi/4)", Factorial(4) + Cos(Math.PI / 4)},
    {"3! + 4!", Factorial(3) + Factorial(4)},
    {"sqrt(49) * exp(1)", Math.Sqrt(49) * Math.Exp(1)},
    {"sin(pi/4) + 5^2", Sin(Math.PI / 4) + Math.Pow(5, 2)},
    {"7! - 6!", Factorial(7) - Factorial(6)},
    {"2^5 / cos(pi/6)", Math.Pow(2, 5) / Cos(Math.PI / 6)},
    {"sqrt(36) + exp(3)", Math.Sqrt(36) + Math.Exp(3)},
    {"cos(pi/3) - 2^4", Cos(Math.PI / 3) - Math.Pow(2, 4)},
    {"4! + sqrt(64)", Factorial(4) + Math.Sqrt(64)},
    {"exp(2) / 3!", Math.Exp(2) / Factorial(3)},
    {"sin(pi/2) * sqrt(16)", Sin(Math.PI / 2) * Math.Sqrt(16)},
    {"5! / (2! * 3!)", Factorial(5) / (Factorial(2) * Factorial(3))},
    {"2^3 + cos(pi/2)", Math.Pow(2, 3) + Cos(Math.PI / 2)},
    {"sqrt(81) - exp(1)", Math.Sqrt(81) - Math.Exp(1)},
    {"3! * 2^2", Factorial(3) * Math.Pow(2, 2)},
    {"cos(pi/4) + sqrt(100)", Cos(Math.PI / 4) + Math.Sqrt(100)},
    {"exp(1) + 4!", Math.Exp(1) + Factorial(4)},
    {"6! / (3! * 3!)", Factorial(6) / (Factorial(3) * Factorial(3))},
    {"sqrt(121) * sin(pi/6)", Math.Sqrt(121) * Sin(Math.PI / 6)},
    {"cos(pi/6) + 5!", Cos(Math.PI / 6) + Factorial(5)},
    {"2^6 - exp(2)", Math.Pow(2, 6) - Math.Exp(2)},
    {"7! + sqrt(49)", Factorial(7) + Math.Sqrt(49)},
    {"sqrt(25) * exp(2)", Math.Sqrt(25) * Math.Exp(2)},
    {"3^3 + cos(pi)", Math.Pow(3, 3) + Cos(Math.PI)},
    {"4! - sin(pi/3)", Factorial(4) - Sin(Math.PI / 3)},
    {"exp(3) + 2^3", Math.Exp(3) + Math.Pow(2, 3)},
    {"cos(pi/2) * sqrt(64)", Cos(Math.PI / 2) * Math.Sqrt(64)},
    {"sin(pi/4) / exp(1)", Sin(Math.PI / 4) / Math.Exp(1)},
    {"sqrt(16) + 3!", Math.Sqrt(16) + Factorial(3)},
    {"2^5 * cos(pi/4)", Math.Pow(2, 5) * Cos(Math.PI / 4)},
    {"4! / sqrt(49)", Factorial(4) / Math.Sqrt(49)},
    {"asin(0.5) + acos(0.8)", Asin(0.5) + Acos(0.8)},
    {"atan(1) + atan(2)", Atan(1) + Atan(2)},
    {"log(10) + lg(8)", Math.Log(10) + Math.Log2(8)},
    {"asin(0.7) + acos(0.6)", Asin(0.7) + Acos(0.6)},
    {"atan(0.5) + atan(3)", Atan(0.5) + Atan(3)},
    {"log(8) + lg(16)", Math.Log(8) + Math.Log2(16)},
    {"asin(0.3) + acos(0.4)", Asin(0.3) + Acos(0.4)},
    {"atan(2) + atan(1)", Atan(2) + Atan(1)},
    {"log(2) + lg (4)", Math.Log(2) + Math.Log2(4)},
    {"asin(0.6) + acos(0.7)", Asin(0.6) + Acos(0.7)},
    {"atan(3) + atan(0.5)", Atan(3) + Atan(0.5)},
    {"log(16) + lg(32)", Math.Log(16) + Math.Log2(32)},
    {"asin(0.4) + acos(0.3)", Asin(0.4) + Acos(0.3)},
    {"atan(1) + atan(4)", Atan(1) + Atan(4)},
    {"log(4) + lg(2)", Math.Log(4) + Math.Log2(2)},
    {"asin(0.8) + acos(0.5)", Asin(0.8) + Acos(0.5)},
    {"atan(0.25) + atan(5)", Atan(0.25) + Atan(5)},
    {"log(32) + lg(64)", Math.Log(32) + Math.Log2(64)},
    {"sqrt(10) * exp(2) - 3^2", Math.Sqrt(10) * Math.Exp(2) - Math.Pow(3, 2)},
    {"asin(0.2) + atan(1) * 2", Asin(0.2) + Atan(1) * 2},
    {"log(20) + lg(5) * sqrt(4)", Math.Log(20) + Math.Log2(5) * Math.Sqrt(4)},
    {"sqrt(15) * exp(3) / 2^2", Math.Sqrt(15) * Math.Exp(3) / Math.Pow(2, 2)},
    {"acos(0.4) + atan(2) / 3!", Acos(0.4) + Atan(2) / Factorial(3)},
    {"log(30) * lg(6) + 2^3", Math.Log(30) * Math.Log2(6) + Math.Pow(2, 3)},
    {"asin(0.5) + acos(0.7) - sqrt(49)", Asin(0.5) + Acos(0.7) - Math.Sqrt(49)},
    {"sqrt(20) + exp(1) * log(5)", Math.Sqrt(20) + Math.Exp(1) * Math.Log(5)},
    {"cos(pi/5) * sqrt(25) + 3^3", Cos(Math.PI / 5) * Math.Sqrt(25) + Math.Pow(3, 3)},
    {"atan(3) / sin(pi/4) + lg(7)", Atan(3) / Sin(Math.PI / 4) + Math.Log2(7)},
    {"sqrt(18) + exp(2) / log(10)", Math.Sqrt(18) + Math.Exp(2) / Math.Log(10)},
    {"acos(0.6) * atan(0.5) - sqrt(16)", Acos(0.6) * Atan(0.5) - Math.Sqrt(16)},
    {"log(40) + lg(8) * sqrt(9)", Math.Log(40) + Math.Log2(8) * Math.Sqrt(9)},
    {"sqrt(12) * exp(3) - 5!", Math.Sqrt(12) * Math.Exp(3) - Factorial(5)},
    {"asin(0.9) + acos(0.1) + 2^6", Asin(0.9) + Acos(0.1) + Math.Pow(2, 6)},
    {"atan(4) * log(15) + lg(3)", Atan(4) * Math.Log(15) + Math.Log2(3)},
    {"sqrt(22) + exp(1) / log(8)", Math.Sqrt(22) + Math.Exp(1) / Math.Log(8)},
    {"cos(pi/6) * sqrt(30) + 4!", Cos(Math.PI / 6) * Math.Sqrt(30) + Factorial(4)},
    {"asin(0.4) + acos(0.2) * sqrt(5)", Asin(0.4) + Acos(0.2) * Math.Sqrt(5)},
    {"log(50) + lg(10) - 3!", Math.Log(50) + Math.Log2(10) - Factorial(3)},
    {"sqrt(25) * exp(2) + 2^4", Math.Sqrt(25) * Math.Exp(2) + Math.Pow(2, 4)},
    {"atan(1) / sin(pi/3) + lg(9)", Atan(1) / Sin(Math.PI / 3) + Math.Log2(9)},
    {"sqrt(14) + exp(1) * log(4)", Math.Sqrt(14) + Math.Exp(1) * Math.Log(4)},
    {"acos(0.8) + atan(0.3) / 2!", Acos(0.8) + Atan(0.3) / Factorial(2)},
    {"log(60) * lg(12) + 3^2", Math.Log(60) * Math.Log2(12) + Math.Pow(3, 2)},
    {"sqrt(21) + exp(3) - 4!", Math.Sqrt(21) + Math.Exp(3) - Factorial(4)},
    {"asin(0.2) + acos(0.5) + 2^5", Asin(0.2) + Acos(0.5) + Math.Pow(2, 5)},
    {"atan(2) * log(18) + lg(2)", Atan(2) * Math.Log(18) + Math.Log2(2)},
    {"sqrt(19) + exp(2) / log(5)", Math.Sqrt(19) + Math.Exp(2) / Math.Log(5)},
    {"cos(pi/4) * sqrt(28) + 5!", Cos(Math.PI / 4) * Math.Sqrt(28) + Factorial(5)},
    {"asin(0.3) + acos(0.1) * sqrt(7)", Asin(0.3) + Acos(0.1) * Math.Sqrt(7)},
    {"log(70) + lg(15) - 4!", Math.Log(70) + Math.Log2(15) - Factorial(4)},
    {"sqrt(24) * exp(2) + 3^4", Math.Sqrt(24) * Math.Exp(2) + Math.Pow(3, 4)},
    {"atan(0.5) / sin(pi/6) + lg(5)", Atan(0.5) / Sin(Math.PI / 6) + Math.Log2(5)},
    {"sqrt(17) + exp(1) * log(6)", Math.Sqrt(17) + Math.Exp(1) * Math.Log(6)},
    {"acos(0.7) + atan(0.2) / 3!", Acos(0.7) + Atan(0.2) / Factorial(3)},
    {"log(80) * lg(18) + 2^5", Math.Log(80) * Math.Log2(18) + Math.Pow(2, 5)},
    {"sqrt(23) + exp(3) - 5!", Math.Sqrt(23) + Math.Exp(3) - Factorial(5)},
    {"asin(0.1) + acos(0.6) + 3^3", Asin(0.1) + Acos(0.6) + Math.Pow(3, 3)},
    {"atan(1) * log(20) + lg(4)", Atan(1) * Math.Log(20) + Math.Log2(4)},
    {"sqrt(27) + exp(2) / log(7)", Math.Sqrt(27) + Math.Exp(2) / Math.Log(7)},
    {"cos(pi/3) * sqrt(35) + 4!", Cos(Math.PI / 3) * Math.Sqrt(35) + Factorial(4)},
    {"asin(0.4) + acos(0.3) * sqrt(9)", Asin(0.4) + Acos(0.3) * Math.Sqrt(9)},
    {"log(90) + lg(20) - 3!", Math.Log(90) + Math.Log2(20) - Factorial(3)},
    {"sqrt(26) * exp(2) + 2^6", Math.Sqrt(26) * Math.Exp(2) + Math.Pow(2, 6)},
    {"atan(0.2) / sin(pi/4) + lg(8)", Atan(0.2) / Sin(Math.PI / 4) + Math.Log2(8)},
    {"sqrt(16) + exp(1) * log(8)", Math.Sqrt(16) + Math.Exp(1) * Math.Log(8)},
    {"acos(0.2) + atan(0.1) / 2!", Acos(0.2) + Atan(0.1) / Factorial(2)},
    {"log(100) * lg(25) + 3^3", Math.Log(100) * Math.Log2(25) + Math.Pow(3, 3)},
    {"sqrt(28) + exp(3) - 2!", Math.Sqrt(28) + Math.Exp(3) - Factorial(2)},
    {"asin(0.7) + acos(0.8) + 2^7", Asin(0.7) + Acos(0.8) + Math.Pow(2, 7)},
    {"atan(0.8) * log(30) + lg(9)", Atan(0.8) * Math.Log(30) + Math.Log2(9)},
    {"sqrt(31) + exp(1) / log(2)", Math.Sqrt(31) + Math.Exp(1) / Math.Log(2)},
    {"cos(pi/4) * sqrt(45) + 5!", Cos(Math.PI / 4) * Math.Sqrt(45) + Factorial(5)},
    {"asin(0.2) + acos(0.1) * sqrt(11)", Asin(0.2) + Acos(0.1) * Math.Sqrt(11)},
    {"log(110) + lg(12) - 4!", Math.Log(110) + Math.Log2(12) - Factorial(4)},
    {"sqrt(34) * exp(2) + 3^5", Math.Sqrt(34) * Math.Exp(2) + Math.Pow(3, 5)},
    {"atan(0.5) / sin(pi/2) + lg(7)", Atan(0.5) / Sin(Math.PI / 2) + Math.Log2(7)},
    {"sqrt(35) + exp(2) * log(9)", Math.Sqrt(35) + Math.Exp(2) * Math.Log(9)},
    {"log(120) * lg(18) + 2^7", Math.Log(120) * Math.Log2(18) + Math.Pow(2, 7)},
    {"sqrt(40) + exp(3) - 5!", Math.Sqrt(40) + Math.Exp(3) - Factorial(5)},
    {"asin(0.6) + acos(0.4) + 3^3", Asin(0.6) + Acos(0.4) + Math.Pow(3, 3)},
    {"atan(0.6) * log(35) + lg(3)", Atan(0.6) * Math.Log(35) + Math.Log2(3)},
    {"sqrt(36) + exp(1) / log(10)", Math.Sqrt(36) + Math.Exp(1) / Math.Log(10)},
    {"cos(pi/6) * sqrt(50) + 4!", Cos(Math.PI / 6) * Math.Sqrt(50) + Factorial(4)},
    {"asin(0.5) + acos(0.2) * sqrt(13)", Asin(0.5) + Acos(0.2) * Math.Sqrt(13)},
    {"log(130) + lg(15) - 3!", Math.Log(130) + Math.Log2(15) - Factorial(3)},
    {"sqrt(42) * exp(2) + 2^8", Math.Sqrt(42) * Math.Exp(2) + Math.Pow(2, 8)},
    {"atan(0.1) / sin(pi/3) + lg(10)", Atan(0.1) / Sin(Math.PI / 3) + Math.Log2(10)},
    {"sqrt(44) + exp(1) * log(12)", Math.Sqrt(44) + Math.Exp(1) * Math.Log(12)},
    {"acos(0.9) + atan(0.4) / 2!", Acos(0.9) + Atan(0.4) / Factorial(2)},
    {"log(140) * lg(20) + 3^2", Math.Log(140) * Math.Log2(20) + Math.Pow(3, 2)},
    {"sqrt(49) + exp(3) - 4!", Math.Sqrt(49) + Math.Exp(3) - Factorial(4)},
    {"asin(0.9) + acos(0.5) + 2^9", Asin(0.9) + Acos(0.5) + Math.Pow(2, 9)},
    {"atan(1) * log(40) + lg(2)", Atan(1) * Math.Log(40) + Math.Log2(2)},
    {"sqrt(52) + exp(2) / log(15)", Math.Sqrt(52) + Math.Exp(2) / Math.Log(15)},
    {"cos(pi/5) * sqrt(55) + 5!", Cos(Math.PI / 5) * Math.Sqrt(55) + Factorial(5)},
    {"asin(0.8) + acos(0.4) * sqrt(14)", Asin(0.8) + Acos(0.4) * Math.Sqrt(14)},
    {"log(150) + lg(25) - 4!", Math.Log(150) + Math.Log2(25) - Factorial(4)},
    {"sqrt(54) * exp(2) + 3^6", Math.Sqrt(54) * Math.Exp(2) + Math.Pow(3, 6)},
    {"atan(0.4) / sin(pi/4) + lg(5)", Atan(0.4) / Sin(Math.PI / 4) + Math.Log2(5)},
    {"sqrt(55) + exp(1) * log(18)", Math.Sqrt(55) + Math.Exp(1) * Math.Log(18)},
    {"acos(0.6) + atan(0.3) / 3!", Acos(0.6) + Atan(0.3) / Factorial(3)},
    {"log(160) * lg(30) + 2^8", Math.Log(160) * Math.Log2(30) + Math.Pow(2, 8)},
    {"sqrt(57) + exp(3) - 5!", Math.Sqrt(57) + Math.Exp(3) - Factorial(5)},
    {"asin(0.4) + acos(0.6) + 3^4", Asin(0.4) + Acos(0.6) + Math.Pow(3, 4)},
    {"atan(0.3) * log(45) + lg(4)", Atan(0.3) * Math.Log(45) + Math.Log2(4)},
    {"sqrt(60) + exp(2) / log(20)", Math.Sqrt(60) + Math.Exp(2) / Math.Log(20)},
    {"cos(pi/3) * sqrt(65) + 4!", Cos(Math.PI / 3) * Math.Sqrt(65) + Factorial(4)},
    {"asin(0.5) + acos(0.3) * sqrt(15)", Asin(0.5) + Acos(0.3) * Math.Sqrt(15)},
    {"log(170) + lg(35) - 3!", Math.Log(170) + Math.Log2(35) - Factorial(3)},
    {"sqrt(62) * exp(2) + 2^9", Math.Sqrt(62) * Math.Exp(2) + Math.Pow(2, 9)},
    {"atan(0.7) / sin(pi/6) + lg(11)", Atan(0.7) / Sin(Math.PI / 6) + Math.Log2(11)},
    {"sqrt(64) + exp(1) * log(22)", Math.Sqrt(64) + Math.Exp(1) * Math.Log(22)},
    {"log(180) * lg(40) + 3^2", Math.Log(180) * Math.Log2(40) + Math.Pow(3, 2)},
    {"sqrt(66) + exp(3) - 4!", Math.Sqrt(66) + Math.Exp(3) - Factorial(4)},
    {"asin(0.2) + acos(0.7) + 2^10", Asin(0.2) + Acos(0.7) + Math.Pow(2, 10)},
    {"atan(0.9) * log(50) + lg(3)", Atan(0.9) * Math.Log(50) + Math.Log2(3)},
    {"sqrt(68) + exp(2) / log(25)", Math.Sqrt(68) + Math.Exp(2) / Math.Log(25)},
    {"cos(pi/4) * sqrt(75) + 5!", Cos(Math.PI / 4) * Math.Sqrt(75) + Factorial(5)},
    {"asin(0.3) + acos(0.8) * sqrt(17)", Asin(0.3) + Acos(0.8) * Math.Sqrt(17)},
    {"log(190) + lg(50) - 4!", Math.Log(190) + Math.Log2(50) - Factorial(4)},
    {"sqrt(70) * exp(2) + 3^7", Math.Sqrt(70) * Math.Exp(2) + Math.Pow(3, 7)},
    {"atan(0.6) / sin(pi/4) + lg(7)", Atan(0.6) / Sin(Math.PI / 4) + Math.Log2(7)},
    {"sqrt(72) + exp(1) * log(30)", Math.Sqrt(72) + Math.Exp(1) * Math.Log(30)},
    {"acos(0.2) + atan(0.4) / 3!", Acos(0.2) + Atan(0.4) / Factorial(3)},
    {"log(200) * lg(60) + 2^9", Math.Log(200) * Math.Log2(60) + Math.Pow(2, 9)},
    {"sqrt(74) + exp(3) - 5!", Math.Sqrt(74) + Math.Exp(3) - Factorial(5)},
    {"asin(0.6) + acos(0.2) + 3^4", Asin(0.6) + Acos(0.2) + Math.Pow(3, 4)},
    {"atan(0.5) * log(55) + lg(6)", Atan(0.5) * Math.Log(55) + Math.Log2(6)},
    {"sqrt(76) + exp(2) / log(35)", Math.Sqrt(76) + Math.Exp(2) / Math.Log(35)},
    {"cos(pi/6) * sqrt(80) + 4!", Cos(Math.PI / 6) * Math.Sqrt(80) + Factorial(4)},
    {"asin(0.7) + acos(0.3) * sqrt(18)", Asin(0.7) + Acos(0.3) * Math.Sqrt(18)},
    {"log(210) + lg(70) - 3!", Math.Log(210) + Math.Log2(70) - Factorial(3)},
    {"sqrt(78) * exp(2) + 2^10", Math.Sqrt(78) * Math.Exp(2) + Math.Pow(2, 10)},
    {"atan(0.2) / sin(pi/5) + lg(8)", Atan(0.2) / Sin(Math.PI / 5) + Math.Log2(8)},
    {"sqrt(80) + exp(1) * log(40)", Math.Sqrt(80) + Math.Exp(1) * Math.Log(40)},
    {"acos(0.5) + atan(0.3) / 2!", Acos(0.5) + Atan(0.3) / Factorial(2)},
    {"log(220) * lg(80) + 3^2", Math.Log(220) * Math.Log2(80) + Math.Pow(3, 2)},
    {"sqrt(82) + exp(3) - 4!", Math.Sqrt(82) + Math.Exp(3) - Factorial(4)},
    {"asin(0.4) + acos(0.9) + 2^11", Asin(0.4) + Acos(0.9) + Math.Pow(2, 11)},
    {"atan(0.9) * log(60) + lg(2)", Atan(0.9) * Math.Log(60) + Math.Log2(2)},
    {"sqrt(84) + exp(2) / log(45)", Math.Sqrt(84) + Math.Exp(2) / Math.Log(45)},
    {"cos(pi/5) * sqrt(90) + 5!", Cos(Math.PI / 5) * Math.Sqrt(90) + Factorial(5)},
    {"asin(0.8) + acos(0.4) * sqrt(19)", Asin(0.8) + Acos(0.4) * Math.Sqrt(19)},
    {"log(230) + lg(90) - 4!", Math.Log(230) + Math.Log2(90) - Factorial(4)},
    {"sqrt(88) * exp(2) + 3^8", Math.Sqrt(88) * Math.Exp(2) + Math.Pow(3, 8)},
    {"atan(0.4) / sin(pi/3) + lg(9)", Atan(0.4) / Sin(Math.PI / 3) + Math.Log2(9)},
    {"sqrt(90) + exp(1) * log(50)", Math.Sqrt(90) + Math.Exp(1) * Math.Log(50)},
    {"acos(0.6) + atan(0.2) / 3!", Acos(0.6) + Atan(0.2) / Factorial(3)},
    {"log(240) * lg(100) + 2^10", Math.Log(240) * Math.Log2(100) + Math.Pow(2, 10)},
    {"sqrt(92) + exp(3) - 5!", Math.Sqrt(92) + Math.Exp(3) - Factorial(5)},
    {"asin(0.5) + acos(0.3) + 3^5", Asin(0.5) + Acos(0.3) + Math.Pow(3, 5)},
    {"atan(0.3) * log(70) + lg(3)", Atan(0.3) * Math.Log(70) + Math.Log2(3)},
    {"sqrt(95) + exp(2) / log(60)", Math.Sqrt(95) + Math.Exp(2) / Math.Log(60)},
    {"cos(pi/4) * sqrt(100) + 4!", Cos(Math.PI / 4) * Math.Sqrt(100) + Factorial(4)},
    {"asin(0.2) + acos(0.8) * sqrt(21)", Asin(0.2) + Acos(0.8) * Math.Sqrt(21)},
    {"log(250) + lg(120) - 3!", Math.Log(250) + Math.Log2(120) - Factorial(3)},
    {"sqrt(98) * exp(2) + 2^11", Math.Sqrt(98) * Math.Exp(2) + Math.Pow(2, 11)},
    {"atan(0.1) / sin(pi/4) + lg(10)", Atan(0.1) / Sin(Math.PI / 4) + Math.Log2(10)},
    {"sqrt(100) + exp(1) * log(70)", Math.Sqrt(100) + Math.Exp(1) * Math.Log(70)},
    {"acos(0.8) + atan(0.6) / 2!", Acos(0.8) + Atan(0.6) / Factorial(2)},
    {"log(260) * lg(150) + 3^2", Math.Log(260) * Math.Log2(150) + Math.Pow(3, 2)},
    {"sqrt(104) + exp(3) - 4!", Math.Sqrt(104) + Math.Exp(3) - Factorial(4)},
    {"asin(0.3) + acos(0.2) + 2^12", Asin(0.3) + Acos(0.2) + Math.Pow(2, 12)},
    {"atan(0.5) * log(80) + lg(4)", Atan(0.5) * Math.Log(80) + Math.Log2(4)},
    {"sqrt(108) + exp(2) / log(80)", Math.Sqrt(108) + Math.Exp(2) / Math.Log(80)},
    {"cos(pi/6) * sqrt(110) + 5!", Cos(Math.PI / 6) * Math.Sqrt(110) + Factorial(5)},
    {"asin(0.7) + acos(0.1) * sqrt(22)", Asin(0.7) + Acos(0.1) * Math.Sqrt(22)},
    {"log(270) + lg(200) - 4!", Math.Log(270) + Math.Log2(200) - Factorial(4)},
    {"sqrt(110) * exp(2) + 3^9", Math.Sqrt(110) * Math.Exp(2) + Math.Pow(3, 9)},
    {"atan(0.3) / sin(pi/5) + lg(11)", Atan(0.3) / Sin(Math.PI / 5) + Math.Log2(11)},
    {"sqrt(115) + exp(1) * log(90)", Math.Sqrt(115) + Math.Exp(1) * Math.Log(90)},
    {"acos(0.3) + atan(0.2) / 3!", Acos(0.3) + Atan(0.2) / Factorial(3)},
    {"log(280) * lg(250) + 2^10", Math.Log(280) * Math.Log2(250) + Math.Pow(2, 10)},
    {"sqrt(118) + exp(3) - 5!", Math.Sqrt(118) + Math.Exp(3) - Factorial(5)},
    {"asin(0.4) + acos(0.5) + 3^4", Asin(0.4) + Acos(0.5) + Math.Pow(3, 4)},
    {"atan(0.7) * log(90) + lg(5)", Atan(0.7) * Math.Log(90) + Math.Log2(5)},
    {"sqrt(120) + exp(2) / log(100)", Math.Sqrt(120) + Math.Exp(2) / Math.Log(100)},
    {"cos(pi/3) * sqrt(125) + 4!", Cos(Math.PI / 3) * Math.Sqrt(125) + Factorial(4)},
    {"asin(0.1) + acos(0.2) * sqrt(23)", Asin(0.1) + Acos(0.2) * Math.Sqrt(23)},
    {"log(290) + lg(300) - 3!", Math.Log(290) + Math.Log2(300) - Factorial(3)},
    {"sqrt(126) * exp(2) + 2^12", Math.Sqrt(126) * Math.Exp(2) + Math.Pow(2, 12)},
    {"atan(0.6) / sin(pi/4) + lg(6)", Atan(0.6) / Sin(Math.PI / 4) + Math.Log2(6)},
    {"sqrt(130) + exp(1) * log(110)", Math.Sqrt(130) + Math.Exp(1) * Math.Log(110)},
    {"acos(0.5) + atan(0.7) / 2!", Acos(0.5) + Atan(0.7) / Factorial(2)},
    {"log(300) * lg(350) + 3^3", Math.Log(300) * Math.Log2(350) + Math.Pow(3, 3)},
    {"sqrt(132) + exp(3) - 4!", Math.Sqrt(132) + Math.Exp(3) - Factorial(4)},
    {"asin(0.5) + acos(0.9) + 2^13", Asin(0.5) + Acos(0.9) + Math.Pow(2, 13)},
    {"atan(0.8) * log(100) + lg(2)", Atan(0.8) * Math.Log(100) + Math.Log2(2)},
    {"sqrt(134) + exp(2) / log(120)", Math.Sqrt(134) + Math.Exp(2) / Math.Log(120)},
    {"cos(pi/4) * sqrt(140) + 5!", Cos(Math.PI / 4) * Math.Sqrt(140) + Factorial(5)},
    {"asin(0.3) + acos(0.1) * sqrt(24)", Asin(0.3) + Acos(0.1) * Math.Sqrt(24)},
    {"log(310) + lg(400) - 4!", Math.Log(310) + Math.Log2(400) - Factorial(4)},
    {"sqrt(136) * exp(2) + 3^10", Math.Sqrt(136) * Math.Exp(2) + Math.Pow(3, 10)},
    {"atan(0.9) / sin(pi/6) + lg(7)", Atan(0.9) / Sin(Math.PI / 6) + Math.Log2(7)},
    {"sqrt(140) + exp(1) * log(130)", Math.Sqrt(140) + Math.Exp(1) * Math.Log(130)},
    {"acos(0.7) + atan(0.6) / 3!", Acos(0.7) + Atan(0.6) / Factorial(3)},
    {"log(320) * lg(450) + 2^11", Math.Log(320) * Math.Log2(450) + Math.Pow(2, 11)},
    {"sqrt(142) + exp(3) - 5!", Math.Sqrt(142) + Math.Exp(3) - Factorial(5)},
    {"asin(0.6) + acos(0.4) + 3^5", Asin(0.6) + Acos(0.4) + Math.Pow(3, 5)},
    {"atan(0.2) * log(110) + lg(3)", Atan(0.2) * Math.Log(110) + Math.Log2(3)},
    {"sqrt(145) + exp(2) / log(140)", Math.Sqrt(145) + Math.Exp(2) / Math.Log(140)},
    {"cos(pi/5) * sqrt(150) + 4!", Cos(Math.PI / 5) * Math.Sqrt(150) + Factorial(4)},
    {"asin(0.9) + acos(0.2) * sqrt(25)", Asin(0.9) + Acos(0.2) * Math.Sqrt(25)},
    {"log(330) + lg(500) - 3!", Math.Log(330) + Math.Log2(500) - Factorial(3)},
    {"sqrt(148) * exp(2) + 2^12", Math.Sqrt(148) * Math.Exp(2) + Math.Pow(2, 12)},
    {"atan(0.4) / sin(pi/3) + lg(8)", Atan(0.4) / Sin(Math.PI / 3) + Math.Log2(8)},
    {"sqrt(150) + exp(1) * log(150)", Math.Sqrt(150) + Math.Exp(1) * Math.Log(150)},
    {"acos(0.9) + atan(0.8) / 2!", Acos(0.9) + Atan(0.8) / Factorial(2)},
    {"log(340) * lg(600) + 3^4", Math.Log(340) * Math.Log2(600) + Math.Pow(3, 4)},
    {"sqrt(154) + exp(3) - 4!", Math.Sqrt(154) + Math.Exp(3) - Factorial(4)},
    {"asin(0.1) + acos(0.7) + 2^14", Asin(0.1) + Acos(0.7) + Math.Pow(2, 14)},
    {"atan(0.5) * log(120) + lg(4)", Atan(0.5) * Math.Log(120) + Math.Log2(4)},
    {"sqrt(156) + exp(2) / log(160)", Math.Sqrt(156) + Math.Exp(2) / Math.Log(160)},
    {"cos(pi/6) * sqrt(165) + 5!", Cos(Math.PI / 6) * Math.Sqrt(165) + Factorial(5)},
    {"asin(0.2) + acos(0.3) * sqrt(26)", Asin(0.2) + Acos(0.3) * Math.Sqrt(26)},
    {"log(350) + lg(700) - 4!", Math.Log(350) + Math.Log2(700) - Factorial(4)},
    {"sqrt(160) * exp(2) + 3^11", Math.Sqrt(160) * Math.Exp(2) + Math.Pow(3, 11)},
    {"atan(0.8) / sin(pi/4) + lg(9)", Atan(0.8) / Sin(Math.PI / 4) + Math.Log2(9)},
    {"sqrt(162) + exp(1) * log(170)", Math.Sqrt(162) + Math.Exp(1) * Math.Log(170)},
    {"acos(0.2) + atan(0.5) / 3!", Acos(0.2) + Atan(0.5) / Factorial(3)},
    {"log(360) * lg(800) + 2^11", Math.Log(360) * Math.Log2(800) + Math.Pow(2, 11)},
    {"sqrt(164) + exp(3) - 5!", Math.Sqrt(164) + Math.Exp(3) - Factorial(5)},
    {"asin(0.3) + acos(0.8) + 3^6", Asin(0.3) + Acos(0.8) + Math.Pow(3, 6)},
    {"atan(0.1) * log(130) + lg(5)", Atan(0.1) * Math.Log(130) + Math.Log2(5)},
    {"sqrt(170) + exp(2) / log(180)", Math.Sqrt(170) + Math.Exp(2) / Math.Log(180)},
    {"cos(pi/4) * sqrt(175) + 4!", Cos(Math.PI / 4) * Math.Sqrt(175) + Factorial(4)},
    {"asin(0.4) + acos(0.6) * sqrt(28)", Asin(0.4) + Acos(0.6) * Math.Sqrt(28)},
    {"log(370) + lg(900) - 3!", Math.Log(370) + Math.Log2(900) - Factorial(3)},
    {"sqrt(178) * exp(2) + 2^13", Math.Sqrt(178) * Math.Exp(2) + Math.Pow(2, 13)},
    {"atan(0.3) / sin(pi/4) + lg(10)", Atan(0.3) / Sin(Math.PI / 4) + Math.Log2(10)},
    {"sqrt(180) + exp(1) * log(190)", Math.Sqrt(180) + Math.Exp(1) * Math.Log(190)},
    {"acos(0.4) + atan(0.6) / 2!", Acos(0.4) + Atan(0.6) / Factorial(2)},
    {"log(380) * lg(1000) + 3^2", Math.Log(380) * Math.Log2(1000) + Math.Pow(3, 2)},
    {"sqrt(184) + exp(3) - 4!", Math.Sqrt(184) + Math.Exp(3) - Factorial(4)},
    {"asin(0.6) + acos(0.5) + 2^14", Asin(0.6) + Acos(0.5) + Math.Pow(2, 14)},
    {"atan(0.4) * log(140) + lg(6)", Atan(0.4) * Math.Log(140) + Math.Log2(6)},
    {"sqrt(190) + exp(2) / log(200)", Math.Sqrt(190) + Math.Exp(2) / Math.Log(200)},
    {"cos(pi/3) * sqrt(195) + 5!", Cos(Math.PI / 3) * Math.Sqrt(195) + Factorial(5)},
    {"asin(0.7) + acos(0.7) * sqrt(30)", Asin(0.7) + Acos(0.7) * Math.Sqrt(30)},
    {"log(390) + lg(1100) - 4!", Math.Log(390) + Math.Log2(1100) - Factorial(4)},
    {"sqrt(194) * exp(2) + 3^12", Math.Sqrt(194) * Math.Exp(2) + Math.Pow(3, 12)}
};
```
</details>

## Acknowledgments 🙏

- Thanks to the contributors of the Stack Overflow community for their valuable insights and solutions.
- Also thanks to ChatGPT for the error handling and documentation 😄

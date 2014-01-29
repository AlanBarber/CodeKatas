#Kata: Leap Year #

## Introduction ##

> A leap year (or intercalary or bissextile year) is a year containing one additional day (or, in the case of lunisolar calendars, a month) in order to keep the calendar year synchronized with the astronomical or seasonal year.
> 
> -<cite>-[Wikipedia (Leap year)](http://en.wikipedia.org/wiki/Leap_year)</cite>


## Rules ##
A leap year is:

1. divisible by 4

2. not divisible by 100, unless it is also divisible by 400.

##Test Cases ##

1. `LeapYear_returns_true_for_1904()`
1. `LeapYear_returns_true_for_1952()`
1. `LeapYear_returns_true_for_2000()`
1. `LeapYear_returns_true_for_2012()`
1. `LeapYear_returns_true_for_2048()`
1. `LeapYear_returns_true_for_2096()`
1. `LeapYear_returns_false_for_1700()`
1. `LeapYear_returns_false_for_1900()`
1. `LeapYear_returns_false_for_2100()`
1. `LeapYear_returns_false_for_2001()`
1. `LeapYear_returns_false_for_2014()`
1. `LeapYear_returns_false_for_2050()` 

## Extra Credit ##

B.C. and 1<sup>st</sup> Century A.D. Leap Years did not follow the pattern above. Extend your `LeapYear.IsLeapYear(int)` method to correctly identify these Leap Years using the details below. Use negative numbers to indicate BCE years.

> The leap year was introduced in the Julian calendar in 46 BC. However, around 10 BC, it was found that the priests in charge of computing the calendar had been adding leap years every three years instead of the four decreed by Caesar (Vardi 1991, p. 239). As a result of this error, no more leap years were added until 8 AD. 
> 
> --<cite>[Eric Weisstein's World of Astronomy](http://scienceworld.wolfram.com/astronomy/LeapYear.html)</cite>

###Extra Credit Test Cases###
1. `LeapYear_returns_false_for_4AD()`
1. `LeapYear_returns_false_for_0AD()`
1. `LeapYear_returns_false_for_50BC()`
1. `LeapYear_returns_true_for_8AD()`
1. `LeapYear_returns_true_for_30BC()`
1. `LeapYear_returns_true_for_45BC()`

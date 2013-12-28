CodeKatas
=========

.Net Code Katas

This is a set of coding katas modified and adjusted to be used in an object-oriented method with unit tests that validate your results.

The tests are already written and base classes with functions are created so all you need to do is start writing code to solve the problems and make the tests pass.

Kata List
---------

 1. FizzBuzz

    Modify the Check() function in FizzBuzz project so that given any integer value will return one of the 4 string values:

    * The input number as a string
    * Fizz if the value is divisible by three
    * Buzz if the value is divisible by five
    * FizzBuzz if the value is divisible by both three and five
    
 1. Binary Numbers - Part 1

    Modify the IntegerToBinary() function

 1. Binary Numbers - Part 2

    Modify the BinaryToInteger() function

 1. Roman Numerals - Part 1

    Modify the ArabicToRomanNumeral() function in the RomanNumerals project so that given any integer value between 1 and 5000, it returns a valid roman numeral.

 1. Roman Numerals - Part 2

    Modify the RomanNumeralToArabic() function in the RomanNumerals project so that given a valid roman numeral , it  returns the arabic number.

 1. Pig Latin - Part 1

    Modify the EnglishToPigLatin() function

    Rules

    * Words that begin with a vowel (a, e, i, o, u) should have "way" appended to the end of the word.
    * Words that begin with consonant have all consonant letters up the first vowel moved to the end of the word and append "ay" to the end

 1. Pig Latin - Part 2

    Modify the PigLatinToEnglish() function

 1. Leap Year

    Modify the IsLeapYear() function

    A leap year is one that is divisible by 4, but not divisible by 100 unless it is also divisible by 400.

 1. Poker Hand Ranking

    Modify the RankHand() function to return the following strings that indicate the highest level of the hand:

    * "Royal Flush" - Special version of straight flush with A, K, Q, J, 10
    * "Straight Flush" - Five cards in sequence of the same suit.
    * "Four of a Kind" - four cards of same rank.
    * "Full House" - three cards of same rank + two cards of same rank.
    * "Flush" - five cards of the same suit.
    * "Straight" - five cards in sequence of different suits.
    * "Three of a Kind" - three cards of same rank.
    * "Two Pair" - two sets of two cards of same rank.
    * "One Pair" - one set of two cards of same rank.
    * (High Card) - return highest ranking card in hand.

 1. Look and Say Sequence

    Modify the CalculateNextSequence() function to calculate the next member of a given inputted look and say sequence

    A look and say sequence is sequence of integers where the next sequence is formed by counting the number of grouped digits in the previous sequence.

    For example, starting at "1" you read as "one number 1" and write it as "11". "11" is read as "two number 1s" and written as "21". "21" is read as "one number 2 and one number 1" and written as "1211".

 1. Mortgage Calculator - Part 1

    Modify the CalculatePurchasePrice() function to calculate the largest purchase price a person could afford given input of term (years), interest rate, monthly payment, and down payment.

 1. Mortgage Calculator - Part 2

    Modify the CalculateMonthlyPayment() function to calculate the monthly payment for a person given inputs of purchase price, down payment, term (years), and interest rate.

 1. Mortgage Calculator - Part 3

    Modify the CalculateDownPayment() function to calculate the required down payment for a person given inputs of purchase price, term (years), interest rate, and monthly payment.

 1. Sudoku Solver

Contributions
-------------

Contributions are welcome, please feel free to fork this project and submit any pull requests to add or modify the katas to improve the project.

Future Ideas
------------

Currently this project only uses the built-in mstest framework. It might be nice to add nunit and mspec versions of test projects for each kata.

License
-------

This project is licensed under the Apache 2.0 License. 
See the file "LICENSE" for more information.

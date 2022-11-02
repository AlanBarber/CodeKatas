CodeKatas
=========

.Net Code Katas

This is a set of coding katas modified and adjusted to be used in an object-oriented method with unit tests that validate your results.

The tests are already written and base classes with functions are created so all you need to do is start writing code to solve the problems and make the tests pass.

Kata List
---------

 1. [FizzBuzz](docs/Fizzbuzz.md)

 1. Reverse String

    Modify the Reverse() function in the ReverseString project to return a string that is the reverse of the inputed string value

	Example:
	* An input value "Hello, World!" should return as "!dlroW ,olleH". 

 1. Count Words

    Modify the Count() function in the CountWords project to return a count of words in a string.
	
	A word is defined as any group of one or more alphanumeric characters separated by a space.

	Example:
	* An input value of "Hello, World!" should return 2.

 1. Palindrome Checker

    Modify the IsPalindrome() function in the PalindromeChecker project to return a boolean (true/false) to indicate if the inputed string is a palindrome.

    Example:
    * "ABBA" is a palindrome
    * "ABAB" is not a palindrome

 1. Pi Calculator - Part 1

    Modify the GetPi() function to return Pi to the given number of decimal digits

	Example:
	* An input value of "2" would return "3.14"

 1. Pi Calculator - Part 2

    Modify the GetPiDigit() function to return a single specified decimal digit of Pi

	Example:
    * An input value of "1" would return "1"
    * An input value of "2" would return "4"

 1. Prime Numbers

    Modify the GetNextPrimeNumber() function to return the next prime number larger than 

 1. Change Return

    Modify the GetChange() function to accept for input a total cost and total paid that returns a sorted array of the bills and coins to give as change

	Valid Change:
	* 100 Dollar Bill
	* 50 Dollar Bill
	* 20 Dollar Bill
	* 10 Dollar Bill
	* 5 Dollar Bill
	* 1 Dollar Bill
	* Half Dollar (50 cent)
	* Quarter (25 cents)
	* Dime (10 cents)
	* Nickel (5 cents)
	* Cent (1 cent)

 1. Binary Numbers - Part 1

    Modify the IntegerToBinary() function in the BinaryNumbers project to convert Decimal integer values between -2,147,483,648 to 2,147,483,647 to 32 bit binary representation of a signed integer in a string.

 1. Binary Numbers - Part 2

    Modify the BinaryToInteger() function in the BinaryNumbers proejct to convert a 32 bit binary representation in string format to a signed integer.

 1. Roman Numerals - Part 1

    Modify the ArabicToRomanNumeral() function in the RomanNumerals project so that given any integer value between 1 and 4999, it returns a valid roman numeral.

	Roman Numeral List:
    * I - 1
    * V - 5
    * X - 10
    * L - 50
    * C - 100
    * D - 500
    * M - 1000

 1. Roman Numerals - Part 2

    Modify the RomanNumeralToArabic() function in the RomanNumerals project so that given a valid roman numeral , it  returns the arabic number.

 1. [Pig Latin - Part 1](docs/Piglatin.md)

    Modify the EnglishToPigLatin() function

    Rules:
    * Words that begin with a vowel (a, e, i, o, u) should have "way" appended to the end of the word.
    * Words that begin with consonant have all consonant letters up the first vowel moved to the end of the word and append "ay" to the end

 1. [Pig Latin - Part 2](docs/Piglatin.md#kata-pig-latin-ii)

    Modify the PigLatinToEnglish() function

 1. [Leap Year](docs/Leapyear.md)


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

    Example sequence:
    * Starting at "1" you read as "one number 1" and write it as "11". 
    * "11" is read as "two number 1s" and written as "21". 
    * "21" is read as "one number 2 and one number 1" and written as "1211".

 1. Mortgage Calculator - Part 1

    Modify the CalculatePurchasePrice() function to calculate the largest purchase price a person could afford given input of term (years), interest rate, monthly payment, and down payment.

 1. Mortgage Calculator - Part 2

    Modify the CalculateMonthlyPayment() function to calculate the monthly payment for a person given inputs of purchase price, down payment, term (years), and interest rate.

 1. Mortgage Calculator - Part 3

    Modify the CalculateDownPayment() function to calculate the required down payment for a person given inputs of purchase price, term (years), interest rate, and monthly payment.

 1. Caesar Cipher - Part 1

	Modify the Encode() function in the CaesarCipher project to encode a string of text using the Caesar Shift Cipher with a provided shift level.

	The Caesar Cipher is is a simple alphabit shift cipher in which each letter is replaced with a coresponding encoded letter that is based on a shift number.

	Example for a 4 shifted cipher:
	* A shifted 4 becomes E
	* B shifted 4 becomes F
	
	So as a result you replace every instance of A with E and B with F. Caesar cipher should always return all values in the original case of the input and should not change any non alphabet characters like numbers, spaces or punctuation.

 1. Caesar Cipher - Part 2

	Modify the Decode() function in the CaesarCipher project to decode an already encoded string of text back into english with a provided shift level.

 1. Sudoku Solver
 
 1. [Income Tax Calculator](docs/Incometax.md)

Contributions
-------------

Contributions are welcome, please feel free to fork this project and submit any pull requests to add or modify the katas to improve the project.

Here are ways you can help:

 * Create a new kata and matching unit test
 * Add more unit tests for existing katas. Ideally we would like a min of 6 tests but the more there are
 * Improve the documentation in the readme; grammar/spell check, make instructions more clear, etc
 * Add documentation to code files
 * Refactor existing code files to follow best practices

Future Ideas
------------

Currently this project only uses the built-in mstest framework. It might be nice to add nunit and mspec versions of test projects for each kata.

Although this project is designed around unit testing it might be nice to create a demo app that makes use of all the Katas to provide some sort of "real world" example of how the code could be used.

License
-------

This project is licensed under the Apache 2.0 License. 
See the file "LICENSE" for more information.

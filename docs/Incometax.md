#Kata: Income Tax Calculator

## Introduction 

The United States Income Tax is a Progressive Tax, broken into brackets by the amount of yearly household income. 


## Rules
The 2013 tax owed for a person filing as Single is:

|Amount Earned | Percentage Owed |
|---: | ---:|
|under $8295 | 10%|
|under $36,250| 15%|
|under $87,850| 25%|
|under $87850| 28%|
|under $183,250|30%|
|under $398,350|33%|
|under $400,000|35%|
|over $400,001|39.6%|

The tax is *progressive*, in that *only the portion of income that falls into a certain bracket is only taxed at that bracket's rate*.

For example, a person making `$10,000` per year would be taxed at `10%` for every dollar in the lowest bracket (`$829.50`), the remaining `$1,705` taxed at `15%` (`$255.75`), for a total tax of `$1,085.25`.

Tax is only owed in whole dollar amounts. The final result should round to the nearest whole dollar. (Round down for 0.01-0.49, and up 0.50 to 0.99).

### Test Cases 

1. `No_Income_Returns_0()`
1. `Negative_Income_Returns_0()`
1. `Income_Of_10000_Returns_1085()`
1. `Income_Of_20000_Returns_2554()`
1. `Income_Of_450000_Returns_135964()`

## Extra Credit 


### Extra Credit Test Cases

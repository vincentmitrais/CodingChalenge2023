====================================================================================
SOLUTION APPROACH
====================================================================================

* To solve this problem, I classify the input numbers into three-digit levels of numbers (Trillion, Billion, Million, Thousand, Hundred, and Cent). For instance: 457,123,456,789,999.25

   25  -> Cent level
   999 -> Hundred level
   789 -> Thousand level
   456 -> Million level
   123 -> Billion level
   457 -> Trillion level

* Then Convert the clasified numbers into spelling according to their level. 
   Example: the level of 457 is trillioin, then convert to "Four Hundred and Fity-Seven Trillion"

  To do so, I am using Pipe and Filter Architecture Style. It alows the input numbers to be passed through each functions that responsible to produce the text of the particular level of number.
  Here are the methods and their responsibilities: 
  - GenerateTextOfTrillionLevel : Respoisible for converting the trillion-level number
  - GenerateTextOfBillionLevel : Respoisible for converting the billion-level number
  - GenerateTextOfMillionLevel : Respoisible for converting the million-level number
  - GenerateTextOfThousandLevel : Respoisible for converting the thousand-level number
  - GenerateTextOfHundredDozenAndBasicLevel : Respoisible for converting hundred, dozen and basic-level numbers
  - AddDollarWord : Respoisible for adding the word "Dollar"
  - GenerateTextOfCentLevel : Respoisible for converting the cent level number

  Please see the implementation in file NumberConverter.cs:30

* To convert the low level number (basic numbers), I created the dictionary for number 1 to 19 to store the text.
  example: - key 1, value "One"	
           - key 2, value "Two"
           - key 3, value "Three"
           - etc

  I also created a dictionary to store the dozens prefix number
  example: - Key 2, value "Twenty"
           - Key 3, value "Thirty"
           - Key 4, value "Forty"
           - etc

  These dictionaries help me convert the basic numbers. Please see the implementation in the file NumberConverterHelper.cs.

  Please see the unit test project to see the proven of number converting of each level



====================================================================================
SCOOPE AND ERROR HANDLING.
====================================================================================
- Input negative number is not allowed
- Only convert 2 digits number after comma. 
- Maximum number level to covert is quintillion level
- Input zero "0" will output the empty string

Note: I've created the unit test to prove the implementation and error handling. Please see the unit test in file BoundaryTest.cs

====================================================================================
WHAT TEST BEEN COVERED IN THIS APP
====================================================================================
1. Cent Level Test
2. Hundred Level Test
3. Thousand Level Test
4. Million Level Test
5. Billion Level Test
6. Trillion Level Test
7. Boundaries/limitation/ exception handling

Note: Please see test project

====================================================================================
HOW TO USE THIS APP. 
====================================================================================
- Open "Publish" folder
- Double click NumberToTextConverter.Desktop.App.exe
  App will be lauched

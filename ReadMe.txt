SOLUTION APPROACH

* To solve this problem, I classify the main numbers into three-digit levels of numbers (Trillion, Billion, Million, Thousand, Hundred, and Cent). For instance: 457,123,456,789,999.25

   25  -> Cent level
   999 -> Hundred level
   789 -> Thousand level
   456 -> Million level
   123 -> Billion level
   457 -> Trillion level

* Then Convert the clasified numbers into spelling according to their level. 
   eg: the level of 457 is trillioin, then convert to "Four Hundred and Fity-Seven Trillion"

  To convert the clasified numbers, I am using pipe and filter architecture style. It alows the input numbers to be passed through each functions that responsible to produce the text of the particular level of number.
  Here are the methods and the responsibilities: 
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

  Please see the unit test project to see the proven of number converting of each leavel



SCOOPE AND ERROR HANDLING.
- Input negative number is not allowed
- Only convert 2 digits number after comma. 
- Maximum number level to covert is quintillion level
- Input zero "0" will output the empty string

Note: I've created the unit test to prove the implementation and error handling. Please see the unit test in file BoundaryTest.cs


HOW TO USE THIS APP. 


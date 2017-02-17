# Word Counter

#### _Finds the instances of a given word inside of a given string_

#### By _**Alexandra Holcombe**_

## Description

This website will take a string and a word from a user, then count the number of times that word occurs inside of the string.

## Setup/Installation Requirements

* Requires DNU, DNX, and Mono
* Clone to local machine
* Use command "dnu restore" in command prompt/shell
* Use command "dnx kestrel" to start server
* Navigate to http://localhost:5004 in web browser of choice

## Specifications

**The user can input a word that is not contained in the string and the application will return 0.**
* Example Input:  
      String: "I love to code"
      Word: "program"
* Example Output:
      0  

    _This input value is simplest because the default return value will be zero; the program assumes that no matches exist until a match is found._

**The user can input a word that matches the entire string and the application will return 1.**
* Example Input:
      String: "bananas"
      Word: "bananas"
* Example Output:
      1

    _The program searches for a simple, complete match between the two provided strings._

**The user can input a word that exists once in the string and the application will return 1.**
* Example Input:
      String: "I love to code"
      Word: "code"
* Example Output:
      1

    _The program checks to see if the string is contained in the string.  If it does, it returns a 1._

**The user can input a word that exists multiple times in the string and the application will return the number of times the word appears.**
* Example Input:
      String: "What's better than coding?  Nothing is better than coding."
      Word: "coding"
* Example Output:
      2

    _The program uses more sophisticated algorithms to determine if the word appears more than once in the string._

**The user can input a word with capitalization and the application will find all occurrences of the word, regardless of case.**
* Example Input:
      String: "What's better than Coding?  Nothing is better than CODING."
      Word: "coding"

* Example Output:
      2

    _This is a small behavior, but is a higher level of specificity and complexity than the previous specification._


## Support and contact details

Please contact Allie Holcombe at alexandra.holcombe@gmail.com with any questions, concerns, or suggestions.

## Technologies Used

This web application uses:
* Nancy
* Mono
* DNVM
* C#
* Razor

### License

*This project is licensed under the MIT license.*

Copyright (c) 2017 **_Alexandra Holcombe_**

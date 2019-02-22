# Word Counter

#### _02/22/2019_

## Author
 **Theary Im**  
 thearyim@gmail.com

## Description
**_This is an application that gathers both a word and sentence from a user, then checks how frequently the word appears in the sentence._**

## Specs
1. Words that have the same exact letters are consider a match.<br/>
      _Example:_
      In the sentence "The phone company has a new phone coming out this week.", the word "phone" will matched 2 times.
      <br/>

2. Wordmatches only match complete full word.<br/>
      _Example:_
      In the sentence "The phone company phones the clients in the phonebook to advertise the new phone.", the word "phone" will matched 2 times. The word "phone" does not match with "phones" or "phonebook"
3. Wordmatches are not case-sensitive.<br/>
      _Example:_
      In the sentence "The phone company advertises their specials on Phone Apps.", the word "phone" and "Phone" will be a match.

4. Wordmatches handles extra white space.<br/>
      _Example:_
      In the sentence "The phone company  advertises their specials on Phone Apps.", the extra white space between the word "company" and "advertise" will not affect the outcome of the word count.

## Setup/Installation Requirements
Download and install .NET Core 2.1.3 SDK and .NET Core Runtime 2.0.9. Download and install Mono.

1. Clone this repository:
"$git clone https://github.com/Thearyim/WordCounter.Solution"

2. Change into the work directory:: $ cd WordCounter.Solution

3. To edit the project, open the project in your preferred text editor.

4. To run the program, first navigate to the location of the WordCounter.cs file then compile and execute: $ cd WordCounter/Models $ mcs WordCounter.cs; mono WordCounter.exe;

5. To run the tests, use these commands: $ cd WordCounter.Tests $ dotnet test

6. To run the program, navigate to WordCounter.Solution/WordCounter and use $dotnet build to build the project, and then $dotnet run to start the server that the project will be held.

7. Navigate to localhost:5000 in your browser to view the splashpage.

Github Repo: https://github.com/Thearyim/WordCounter.Solution

**.NET is Required for this project to function.**

## Known Bugs
_No known bugs._

## Technologies Used
* _C#_
* _HTML_
* _CSS_
* _.NET_
* _Git_
* _Bing_
* _MSTest_

## License
MIT

Copyright (c) 2019 **_Theary Im_**

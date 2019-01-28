# Multi Bracket Validation

## Challenge
- Create a method called public static bool MultiBracketValidation(string input). Your function should take a string as its only argument, and should return a boolean representing whether or not the brackets in the string are balanced.
- There are 3 types of brackets:

	- Round Brackets : ()
	- Square Brackets : []
	- Curly Brackets : {}

## Approach & Efficiency
1.  Big O Time = O(1) // Big O Space = O(1)

## Examples

Input | Output
------|-------
{} | TRUE
{}(){} | TRUE
()[[Extra Characters]] | TRUE
(){}[[]] | TRUE
{}{Code}[Fellows](()) | TRUE
[({}] | FALSE
(]( | FALSE
{(}) | FALSE

## Solution

![Whiteboard](whiteboard_img.png)

## Thank you!

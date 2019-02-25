<h1 align="center">Unique Character Validator</h1>
Determine if a string is full of unique characters

## Challenge
- Write a method that will determine if a given string is full of unique characters.
- We can assume that spaces don’t count, and the charactes are not case sensitive (i.e. “A” is the same as “a”).
- **Stretch Goal:** Take case sensitivity into account. (i.e. “A” and “a” are not the same. )

## Approach
This method boils down to splitting out a string into characters, hashing them, then checking for collisions. If we have a collision, we know the string is not full of unique characters, as each character will map to the same index given the design. If no collisions are found, or the input string is empty, we know that all characters are unique.

## Efficiency
- Time: O(n)
- Space: O(n)

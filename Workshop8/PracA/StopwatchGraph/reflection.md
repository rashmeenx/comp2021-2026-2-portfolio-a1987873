## 1. What is the Big-O notation complexity of the Append method?
The Append method using:
aOutput += "z";
has approximately O(n²) complexity when repeatedly building a string.

## 2. How does your evidence support this conclusion?
The graph shows that the execution time increases faster as the number of iterations increases, rather than increasing at a constant rate. This curved increase is consistent with quadratic growth.
This occurs because strings are immutable in C#. Every time a character is appended, a new string is created and the contents of the previous string must be copied.
For example:
z
zz
zzz
zzzz
Here, C# is repeatedly copying the existing contents into a new string.
## 3. What is the Big-O notation complexity of the Builder method?
The StringBuilder approach has approximately O(n) complexity for repeated appending.
## 4. How does your evidence support this conclusion?
The StringBuilder graph should increase much more gradually and approximately linearly as the number of iterations increases.
StringBuilder is designed to modify and expand its internal buffer efficiently instead of creating and copying an entirely new string after every append.
## 1. Which approach was faster? Append or Build?
The Build approach using StringBuilder was much faster than appending.

## 2. Why?
Strings in C# are immutable, meaning they cannot be changed after they are created. Every time aOutput += "z" is used, C# creates a new string and copies the existing contents into it. As the string gets larger, this becomes increasingly expensive. StringBuilder is designed for repeated modifications and can append characters without creating a completely new string each time, so it scales much better.